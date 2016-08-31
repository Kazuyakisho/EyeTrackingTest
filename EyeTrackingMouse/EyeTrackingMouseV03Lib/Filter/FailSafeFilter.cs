using System;
using System.Runtime.Serialization;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml;
using AForge.Imaging;
using AForge.Imaging.Filters;
using EyeTrackingMouseV03Lib.Helper;
using EyeTrackingMouseV03Lib.Log;
using EyeTrackingMouseV03Lib.Utils;
using System.Threading.Tasks;

namespace EyeTrackingMouseV03Lib.Filter
{
    [DataContract]
    [KnownType("DerivedTypes")]
    public abstract class FailSafeFilter : IFilter
    {
        private IFilter _filter;
        protected IFilter Filter
        {
            get
            {
                if (_filter == null) _filter = CreateFilter();
                return _filter;
            }
        }
        [DataMember]
        public virtual bool Worked { get; protected set; }
        [DataMember]
        public virtual PixelFormat SupportedFormat { get; private set; }
        [DataMember]
        private bool _worksWithoutConversion;

        private static Type[] DerivedTypes()
        {
            return typeof(FailSafeFilter).GetDerivedTypes(Assembly.GetExecutingAssembly()).ToArray();
        }

        protected abstract IFilter CreateFilter();

        public virtual UnmanagedImage Apply(UnmanagedImage image)
        {
            if (Filter == null) CreateFilter();
            UnmanagedImage _image;
            try
            {
                if (!_worksWithoutConversion)
                {
                    if (SupportedFormat == PixelFormat.Undefined)
                    {
                        var _validFormats = ((IFilterInformation)Filter).FormatTranslations;
                        if (_validFormats.ContainsKey(image.PixelFormat))
                            _worksWithoutConversion = true;
                        else
                            SupportedFormat = _validFormats.Max(p => p.Key);
                    }
                    _image = image.ConvertToFormat(SupportedFormat);
                    _image = Filter.Apply(_image);
                }
                else
                {
                    _image = Filter.Apply(image);
                }
                Worked = true;
                return _image;
            }
            catch (Exception ex)
            {
                ErrorLogger.ProcessException(ex, false);
                Worked = false;
                _worksWithoutConversion = false;
                SupportedFormat = PixelFormat.Undefined;
                return image;
            }
        }

        public Task<UnmanagedImage> ApplyAsync(UnmanagedImage image)
        { return new Task<UnmanagedImage>(() => Apply(image)); }

        public virtual void Apply(UnmanagedImage sourceImage, UnmanagedImage destinationImage) { throw new NotImplementedException(); }

        public virtual Bitmap Apply(Bitmap image) { throw new NotImplementedException(); }

        public virtual Bitmap Apply(BitmapData imageData) { throw new NotImplementedException(); }

        protected Exception GenerateSetterException(Exception ex, [CallerMemberName] string memberName = "")
        { return new Exception("Error setting " + memberName + " of " + Filter.GetType() + "."); }

        public void Save(string filePath) { Save(this, filePath); }

        public static void Save(FailSafeFilter filter, string filePath)
        {
            try
            {
                using (var stream = File.Open(filePath, FileMode.Create))
                {
                    using (var writer = XmlDictionaryWriter.CreateTextWriter(stream, Encoding.UTF8))
                    {
                        var dcs = new DataContractSerializer(typeof(FailSafeFilter));
                        dcs.WriteObject(writer, filter);
                    }
                }
            }
            catch (Exception ex)
            { ErrorLogger.ProcessException(new Exception("Error saving filter to file "+filePath, ex), true); }
        }

        public static FailSafeFilter Load(string filePath)
        {
            try
            {
                using (var stream = File.Open(filePath, FileMode.Open))
                {
                    using (var reader = XmlDictionaryReader.CreateTextReader(stream, new XmlDictionaryReaderQuotas()))
                    {
                        var dcs = new DataContractSerializer(typeof(FailSafeFilter));
                        return (FailSafeFilter)dcs.ReadObject(reader);
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.ProcessException(new Exception("Error loading filter from file "+filePath, ex), true);
                return new FailSafeFilterDummy();
            }

        }
    }
}
