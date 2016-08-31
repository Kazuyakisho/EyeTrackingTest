namespace EyeTrackeringMouseV03
{
    sealed partial class FilterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbGabor = new System.Windows.Forms.CheckBox();
            this.cbSURF = new System.Windows.Forms.CheckBox();
            this.cbConvolution = new System.Windows.Forms.CheckBox();
            this.cbHarrisCornerDetector = new System.Windows.Forms.CheckBox();
            this.cbFastCornerDetector = new System.Windows.Forms.CheckBox();
            this.cbSISThreshold = new System.Windows.Forms.CheckBox();
            this.cbSobel = new System.Windows.Forms.CheckBox();
            this.cbCanny = new System.Windows.Forms.CheckBox();
            this.cbThres = new System.Windows.Forms.CheckBox();
            this.cbSharpen = new System.Windows.Forms.CheckBox();
            this.cbCons = new System.Windows.Forms.CheckBox();
            this.cbEuc = new System.Windows.Forms.CheckBox();
            this.cbInvert = new System.Windows.Forms.CheckBox();
            this.gbGaussianBlur = new System.Windows.Forms.GroupBox();
            this.trackBar5 = new System.Windows.Forms.TrackBar();
            this.trackBar4 = new System.Windows.Forms.TrackBar();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbChannelExtr = new System.Windows.Forms.CheckBox();
            this.cbGaus = new System.Windows.Forms.CheckBox();
            this.cbContour = new System.Windows.Forms.CheckBox();
            this.cbGamma = new System.Windows.Forms.CheckBox();
            this.cbBrightness = new System.Windows.Forms.CheckBox();
            this.cbFilterGrayScale = new System.Windows.Forms.CheckBox();
            this.gbGrayscale = new System.Windows.Forms.GroupBox();
            this.lblGrayCrValue = new System.Windows.Forms.Label();
            this.lblGrayCgValue = new System.Windows.Forms.Label();
            this.lblGrayCbValue = new System.Windows.Forms.Label();
            this.tBarGrayCb = new System.Windows.Forms.TrackBar();
            this.tBarGrayCg = new System.Windows.Forms.TrackBar();
            this.tBarGrayCr = new System.Windows.Forms.TrackBar();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gbChannel = new System.Windows.Forms.GroupBox();
            this.rbChannelRed = new System.Windows.Forms.RadioButton();
            this.rbChannelBlue = new System.Windows.Forms.RadioButton();
            this.rbChannelGreen = new System.Windows.Forms.RadioButton();
            this.gbEuc = new System.Windows.Forms.GroupBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.cbFillOutSide = new System.Windows.Forms.CheckBox();
            this.lblEucGreenValue = new System.Windows.Forms.Label();
            this.lblEucBlueValue = new System.Windows.Forms.Label();
            this.lblEucRadValue = new System.Windows.Forms.Label();
            this.lblEucValue = new System.Windows.Forms.Label();
            this.tBarEucRa = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.tBarEucBlue = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.tBarEucGreen = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.tBarEucRed = new System.Windows.Forms.TrackBar();
            this.label10 = new System.Windows.Forms.Label();
            this.gbThress = new System.Windows.Forms.GroupBox();
            this.lblThresValue = new System.Windows.Forms.Label();
            this.tBarThres = new System.Windows.Forms.TrackBar();
            this.gbBrightness = new System.Windows.Forms.GroupBox();
            this.lblBrithValue = new System.Windows.Forms.Label();
            this.tBarBrightness = new System.Windows.Forms.TrackBar();
            this.gbNoise = new System.Windows.Forms.GroupBox();
            this.lblConsValue = new System.Windows.Forms.Label();
            this.tBarCons = new System.Windows.Forms.TrackBar();
            this.gbGamma = new System.Windows.Forms.GroupBox();
            this.lblGammaValue = new System.Windows.Forms.Label();
            this.tBarGamma = new System.Windows.Forms.TrackBar();
            this.button1 = new System.Windows.Forms.Button();
            this.gbCanny = new System.Windows.Forms.GroupBox();
            this.lblCanGausValue = new System.Windows.Forms.Label();
            this.lblCanHThresValue = new System.Windows.Forms.Label();
            this.lblCanLThresValue = new System.Windows.Forms.Label();
            this.lblCanSigmaValue = new System.Windows.Forms.Label();
            this.tBarCanLThres = new System.Windows.Forms.TrackBar();
            this.label15 = new System.Windows.Forms.Label();
            this.tBarCanHThres = new System.Windows.Forms.TrackBar();
            this.label16 = new System.Windows.Forms.Label();
            this.tBarCanGaus = new System.Windows.Forms.TrackBar();
            this.label17 = new System.Windows.Forms.Label();
            this.tBarCanSig = new System.Windows.Forms.TrackBar();
            this.label18 = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.gbGaussian = new System.Windows.Forms.GroupBox();
            this.lblGausKernel = new System.Windows.Forms.Label();
            this.lblGausValue = new System.Windows.Forms.Label();
            this.tBarGausValue = new System.Windows.Forms.TrackBar();
            this.tBarGausKernel = new System.Windows.Forms.TrackBar();
            this.label14 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.gpContour = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.tbContourDRangeMax = new System.Windows.Forms.TextBox();
            this.tbContourDRangeMin = new System.Windows.Forms.TextBox();
            this.lblContourKernel = new System.Windows.Forms.Label();
            this.lblContourSuppresion = new System.Windows.Forms.Label();
            this.lblContourThres = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.tBarContourSupression = new System.Windows.Forms.TrackBar();
            this.Suspression = new System.Windows.Forms.Label();
            this.tBarContourKernel = new System.Windows.Forms.TrackBar();
            this.Kernel = new System.Windows.Forms.Label();
            this.tBarContourThreshold = new System.Windows.Forms.TrackBar();
            this.label23 = new System.Windows.Forms.Label();
            this.gpFAST = new System.Windows.Forms.GroupBox();
            this.cbFASTSuppress = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblFASTGetValueAvr = new System.Windows.Forms.Label();
            this.tBarFASTThres = new System.Windows.Forms.TrackBar();
            this.gbConv = new System.Windows.Forms.GroupBox();
            this.cbConvDynamic = new System.Windows.Forms.CheckBox();
            this.cbConvProcessAlpha = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblConvValue = new System.Windows.Forms.Label();
            this.tBarConvThres = new System.Windows.Forms.TrackBar();
            this.gbHarrisDetector = new System.Windows.Forms.GroupBox();
            this.cbHarrisIsNoble = new System.Windows.Forms.CheckBox();
            this.lblHarrisSigmaValue = new System.Windows.Forms.Label();
            this.lblHarrisThresValue = new System.Windows.Forms.Label();
            this.lblHarrisSupressValue = new System.Windows.Forms.Label();
            this.lblHarrisKValue = new System.Windows.Forms.Label();
            this.tBarHarristBar = new System.Windows.Forms.TrackBar();
            this.tBarHarrisSupress = new System.Windows.Forms.Label();
            this.tBarHarrisThres = new System.Windows.Forms.TrackBar();
            this.label27 = new System.Windows.Forms.Label();
            this.tBarHarrisSigma = new System.Windows.Forms.TrackBar();
            this.lblddHarrisSigma = new System.Windows.Forms.Label();
            this.tBarHarrisK = new System.Windows.Forms.TrackBar();
            this.label29 = new System.Windows.Forms.Label();
            this.gbSobel = new System.Windows.Forms.GroupBox();
            this.cbSolbelScaleIntens = new System.Windows.Forms.CheckBox();
            this.gBSurf = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.rbSURFDTNone = new System.Windows.Forms.RadioButton();
            this.rdSURFDTStandard = new System.Windows.Forms.RadioButton();
            this.cbSURFCompute = new System.Windows.Forms.CheckBox();
            this.rbSURFDTExtended = new System.Windows.Forms.RadioButton();
            this.lblSURFThres = new System.Windows.Forms.Label();
            this.lblSURFStep = new System.Windows.Forms.Label();
            this.lblSURFOctave = new System.Windows.Forms.Label();
            this.tBarSURFStep = new System.Windows.Forms.TrackBar();
            this.label26 = new System.Windows.Forms.Label();
            this.tBarSURFThres = new System.Windows.Forms.TrackBar();
            this.label28 = new System.Windows.Forms.Label();
            this.tBarSURFOctaves = new System.Windows.Forms.TrackBar();
            this.label30 = new System.Windows.Forms.Label();
            this.gbGabor = new System.Windows.Forms.GroupBox();
            this.label35 = new System.Windows.Forms.Label();
            this.tBarGaborTheta = new System.Windows.Forms.TrackBar();
            this.lblGaborTheta = new System.Windows.Forms.Label();
            this.lblGaborGamma = new System.Windows.Forms.Label();
            this.lblGaborLambda = new System.Windows.Forms.Label();
            this.lblGaborSigma = new System.Windows.Forms.Label();
            this.lblGaborSize = new System.Windows.Forms.Label();
            this.tBarGaborSigma = new System.Windows.Forms.TrackBar();
            this.label31 = new System.Windows.Forms.Label();
            this.tBarGaborLambda = new System.Windows.Forms.TrackBar();
            this.label32 = new System.Windows.Forms.Label();
            this.tBarGaborGamma = new System.Windows.Forms.TrackBar();
            this.label33 = new System.Windows.Forms.Label();
            this.tBarGaborSize = new System.Windows.Forms.TrackBar();
            this.label34 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gbGaussianBlur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).BeginInit();
            this.gbGrayscale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBarGrayCb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBarGrayCg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBarGrayCr)).BeginInit();
            this.gbChannel.SuspendLayout();
            this.gbEuc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBarEucRa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBarEucBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBarEucGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBarEucRed)).BeginInit();
            this.gbThress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBarThres)).BeginInit();
            this.gbBrightness.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBarBrightness)).BeginInit();
            this.gbNoise.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBarCons)).BeginInit();
            this.gbGamma.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBarGamma)).BeginInit();
            this.gbCanny.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBarCanLThres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBarCanHThres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBarCanGaus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBarCanSig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.gbGaussian.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBarGausValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBarGausKernel)).BeginInit();
            this.gpContour.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBarContourSupression)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBarContourKernel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBarContourThreshold)).BeginInit();
            this.gpFAST.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBarFASTThres)).BeginInit();
            this.gbConv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBarConvThres)).BeginInit();
            this.gbHarrisDetector.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBarHarristBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBarHarrisThres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBarHarrisSigma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBarHarrisK)).BeginInit();
            this.gbSobel.SuspendLayout();
            this.gBSurf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBarSURFStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBarSURFThres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBarSURFOctaves)).BeginInit();
            this.gbGabor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBarGaborTheta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBarGaborSigma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBarGaborLambda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBarGaborGamma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBarGaborSize)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbGabor);
            this.groupBox1.Controls.Add(this.cbSURF);
            this.groupBox1.Controls.Add(this.cbConvolution);
            this.groupBox1.Controls.Add(this.cbHarrisCornerDetector);
            this.groupBox1.Controls.Add(this.cbFastCornerDetector);
            this.groupBox1.Controls.Add(this.cbSISThreshold);
            this.groupBox1.Controls.Add(this.cbSobel);
            this.groupBox1.Controls.Add(this.cbCanny);
            this.groupBox1.Controls.Add(this.cbThres);
            this.groupBox1.Controls.Add(this.cbSharpen);
            this.groupBox1.Controls.Add(this.cbCons);
            this.groupBox1.Controls.Add(this.cbEuc);
            this.groupBox1.Controls.Add(this.cbInvert);
            this.groupBox1.Controls.Add(this.gbGaussianBlur);
            this.groupBox1.Controls.Add(this.cbChannelExtr);
            this.groupBox1.Controls.Add(this.cbGaus);
            this.groupBox1.Controls.Add(this.cbContour);
            this.groupBox1.Controls.Add(this.cbGamma);
            this.groupBox1.Controls.Add(this.cbBrightness);
            this.groupBox1.Controls.Add(this.cbFilterGrayScale);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(119, 462);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // cbGabor
            // 
            this.cbGabor.AutoSize = true;
            this.cbGabor.Location = new System.Drawing.Point(6, 445);
            this.cbGabor.Name = "cbGabor";
            this.cbGabor.Size = new System.Drawing.Size(55, 17);
            this.cbGabor.TabIndex = 23;
            this.cbGabor.Text = "Gabor";
            this.cbGabor.UseVisualStyleBackColor = true;
            this.cbGabor.CheckedChanged += new System.EventHandler(this.cbGabor_CheckedChanged);
            // 
            // cbSURF
            // 
            this.cbSURF.AutoSize = true;
            this.cbSURF.Location = new System.Drawing.Point(7, 423);
            this.cbSURF.Name = "cbSURF";
            this.cbSURF.Size = new System.Drawing.Size(99, 17);
            this.cbSURF.TabIndex = 22;
            this.cbSURF.Text = "SURF Detector";
            this.cbSURF.UseVisualStyleBackColor = true;
            this.cbSURF.CheckedChanged += new System.EventHandler(this.cbSURF_CheckedChanged);
            // 
            // cbConvolution
            // 
            this.cbConvolution.AutoSize = true;
            this.cbConvolution.Location = new System.Drawing.Point(7, 292);
            this.cbConvolution.Name = "cbConvolution";
            this.cbConvolution.Size = new System.Drawing.Size(84, 17);
            this.cbConvolution.TabIndex = 21;
            this.cbConvolution.Text = "Convolusion";
            this.cbConvolution.UseVisualStyleBackColor = true;
            this.cbConvolution.CheckedChanged += new System.EventHandler(this.cbConvolution_CheckedChanged);
            // 
            // cbHarrisCornerDetector
            // 
            this.cbHarrisCornerDetector.AutoSize = true;
            this.cbHarrisCornerDetector.Location = new System.Drawing.Point(7, 400);
            this.cbHarrisCornerDetector.Name = "cbHarrisCornerDetector";
            this.cbHarrisCornerDetector.Size = new System.Drawing.Size(131, 17);
            this.cbHarrisCornerDetector.TabIndex = 20;
            this.cbHarrisCornerDetector.Text = "Harris Corner Detector";
            this.cbHarrisCornerDetector.UseVisualStyleBackColor = true;
            this.cbHarrisCornerDetector.CheckedChanged += new System.EventHandler(this.cbHarrisCornerDetector_CheckedChanged);
            // 
            // cbFastCornerDetector
            // 
            this.cbFastCornerDetector.AutoSize = true;
            this.cbFastCornerDetector.Location = new System.Drawing.Point(7, 378);
            this.cbFastCornerDetector.Name = "cbFastCornerDetector";
            this.cbFastCornerDetector.Size = new System.Drawing.Size(131, 17);
            this.cbFastCornerDetector.TabIndex = 19;
            this.cbFastCornerDetector.Text = "FAST Corner Detector";
            this.cbFastCornerDetector.UseVisualStyleBackColor = true;
            this.cbFastCornerDetector.CheckedChanged += new System.EventHandler(this.cbFastCornerDetector_CheckedChanged);
            // 
            // cbSISThreshold
            // 
            this.cbSISThreshold.AutoSize = true;
            this.cbSISThreshold.Location = new System.Drawing.Point(7, 249);
            this.cbSISThreshold.Name = "cbSISThreshold";
            this.cbSISThreshold.Size = new System.Drawing.Size(90, 17);
            this.cbSISThreshold.TabIndex = 18;
            this.cbSISThreshold.Text = "SISThreshold";
            this.cbSISThreshold.UseVisualStyleBackColor = true;
            this.cbSISThreshold.CheckedChanged += new System.EventHandler(this.cbSISThreshold_CheckedChanged);
            // 
            // cbSobel
            // 
            this.cbSobel.AutoSize = true;
            this.cbSobel.Location = new System.Drawing.Point(7, 355);
            this.cbSobel.Name = "cbSobel";
            this.cbSobel.Size = new System.Drawing.Size(81, 17);
            this.cbSobel.TabIndex = 17;
            this.cbSobel.Text = "Sobel Edge";
            this.cbSobel.UseVisualStyleBackColor = true;
            this.cbSobel.CheckedChanged += new System.EventHandler(this.cbSobel_CheckedChanged);
            // 
            // cbCanny
            // 
            this.cbCanny.AutoSize = true;
            this.cbCanny.Location = new System.Drawing.Point(7, 335);
            this.cbCanny.Name = "cbCanny";
            this.cbCanny.Size = new System.Drawing.Size(56, 17);
            this.cbCanny.TabIndex = 16;
            this.cbCanny.Text = "Canny";
            this.cbCanny.UseVisualStyleBackColor = true;
            this.cbCanny.CheckedChanged += new System.EventHandler(this.cbCanny_CheckedChanged);
            // 
            // cbThres
            // 
            this.cbThres.AutoSize = true;
            this.cbThres.Location = new System.Drawing.Point(7, 226);
            this.cbThres.Name = "cbThres";
            this.cbThres.Size = new System.Drawing.Size(73, 17);
            this.cbThres.TabIndex = 15;
            this.cbThres.Text = "Threshold";
            this.cbThres.UseVisualStyleBackColor = true;
            this.cbThres.CheckedChanged += new System.EventHandler(this.cbThres_CheckedChanged);
            // 
            // cbSharpen
            // 
            this.cbSharpen.AutoSize = true;
            this.cbSharpen.Location = new System.Drawing.Point(7, 203);
            this.cbSharpen.Name = "cbSharpen";
            this.cbSharpen.Size = new System.Drawing.Size(66, 17);
            this.cbSharpen.TabIndex = 14;
            this.cbSharpen.Text = "Sharpen";
            this.cbSharpen.UseVisualStyleBackColor = true;
            this.cbSharpen.CheckedChanged += new System.EventHandler(this.cbSharpen_CheckedChanged);
            // 
            // cbCons
            // 
            this.cbCons.AutoSize = true;
            this.cbCons.Location = new System.Drawing.Point(7, 180);
            this.cbCons.Name = "cbCons";
            this.cbCons.Size = new System.Drawing.Size(91, 17);
            this.cbCons.TabIndex = 13;
            this.cbCons.Text = "Noise Reduct";
            this.cbCons.UseVisualStyleBackColor = true;
            this.cbCons.CheckedChanged += new System.EventHandler(this.cbCons_CheckedChanged);
            // 
            // cbEuc
            // 
            this.cbEuc.AutoSize = true;
            this.cbEuc.Location = new System.Drawing.Point(7, 43);
            this.cbEuc.Name = "cbEuc";
            this.cbEuc.Size = new System.Drawing.Size(69, 17);
            this.cbEuc.TabIndex = 12;
            this.cbEuc.Text = "Euclidian";
            this.cbEuc.UseVisualStyleBackColor = true;
            this.cbEuc.CheckedChanged += new System.EventHandler(this.cbEuc_CheckedChanged);
            // 
            // cbInvert
            // 
            this.cbInvert.AutoSize = true;
            this.cbInvert.Location = new System.Drawing.Point(7, 66);
            this.cbInvert.Name = "cbInvert";
            this.cbInvert.Size = new System.Drawing.Size(53, 17);
            this.cbInvert.TabIndex = 11;
            this.cbInvert.Text = "Invert";
            this.cbInvert.UseVisualStyleBackColor = true;
            this.cbInvert.CheckedChanged += new System.EventHandler(this.cbInvert_CheckedChanged);
            // 
            // gbGaussianBlur
            // 
            this.gbGaussianBlur.Controls.Add(this.trackBar5);
            this.gbGaussianBlur.Controls.Add(this.trackBar4);
            this.gbGaussianBlur.Controls.Add(this.label12);
            this.gbGaussianBlur.Controls.Add(this.label11);
            this.gbGaussianBlur.Location = new System.Drawing.Point(125, 273);
            this.gbGaussianBlur.Name = "gbGaussianBlur";
            this.gbGaussianBlur.Size = new System.Drawing.Size(290, 152);
            this.gbGaussianBlur.TabIndex = 8;
            this.gbGaussianBlur.TabStop = false;
            this.gbGaussianBlur.Text = "GaussianBlur";
            // 
            // trackBar5
            // 
            this.trackBar5.Location = new System.Drawing.Point(9, 101);
            this.trackBar5.Name = "trackBar5";
            this.trackBar5.Size = new System.Drawing.Size(266, 45);
            this.trackBar5.TabIndex = 16;
            this.trackBar5.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            // 
            // trackBar4
            // 
            this.trackBar4.Location = new System.Drawing.Point(9, 40);
            this.trackBar4.Name = "trackBar4";
            this.trackBar4.Size = new System.Drawing.Size(266, 45);
            this.trackBar4.TabIndex = 16;
            this.trackBar4.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 84);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Ker.:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Gaus Value";
            // 
            // cbChannelExtr
            // 
            this.cbChannelExtr.AutoSize = true;
            this.cbChannelExtr.Location = new System.Drawing.Point(7, 89);
            this.cbChannelExtr.Name = "cbChannelExtr";
            this.cbChannelExtr.Size = new System.Drawing.Size(115, 17);
            this.cbChannelExtr.TabIndex = 10;
            this.cbChannelExtr.Text = "Channel Extraction";
            this.cbChannelExtr.UseVisualStyleBackColor = true;
            this.cbChannelExtr.CheckedChanged += new System.EventHandler(this.cbChannelExtr_CheckedChanged);
            // 
            // cbGaus
            // 
            this.cbGaus.AutoSize = true;
            this.cbGaus.Location = new System.Drawing.Point(7, 112);
            this.cbGaus.Name = "cbGaus";
            this.cbGaus.Size = new System.Drawing.Size(70, 17);
            this.cbGaus.TabIndex = 9;
            this.cbGaus.Text = "Gaussian";
            this.cbGaus.UseVisualStyleBackColor = true;
            this.cbGaus.CheckedChanged += new System.EventHandler(this.cbGaus_CheckedChanged);
            // 
            // cbContour
            // 
            this.cbContour.AutoSize = true;
            this.cbContour.Location = new System.Drawing.Point(7, 313);
            this.cbContour.Name = "cbContour";
            this.cbContour.Size = new System.Drawing.Size(63, 17);
            this.cbContour.TabIndex = 8;
            this.cbContour.Text = "Contour";
            this.cbContour.UseVisualStyleBackColor = true;
            this.cbContour.CheckedChanged += new System.EventHandler(this.cbContour_CheckedChanged);
            // 
            // cbGamma
            // 
            this.cbGamma.AutoSize = true;
            this.cbGamma.Location = new System.Drawing.Point(7, 157);
            this.cbGamma.Name = "cbGamma";
            this.cbGamma.Size = new System.Drawing.Size(87, 17);
            this.cbGamma.TabIndex = 7;
            this.cbGamma.Text = "Gramma Corr";
            this.cbGamma.UseVisualStyleBackColor = true;
            this.cbGamma.CheckedChanged += new System.EventHandler(this.cbGamma_CheckedChanged);
            // 
            // cbBrightness
            // 
            this.cbBrightness.AutoSize = true;
            this.cbBrightness.Location = new System.Drawing.Point(7, 134);
            this.cbBrightness.Name = "cbBrightness";
            this.cbBrightness.Size = new System.Drawing.Size(75, 17);
            this.cbBrightness.TabIndex = 4;
            this.cbBrightness.Text = "Brightness";
            this.cbBrightness.UseVisualStyleBackColor = true;
            this.cbBrightness.CheckedChanged += new System.EventHandler(this.cbBrightness_CheckedChanged);
            // 
            // cbFilterGrayScale
            // 
            this.cbFilterGrayScale.AutoSize = true;
            this.cbFilterGrayScale.Location = new System.Drawing.Point(7, 20);
            this.cbFilterGrayScale.Name = "cbFilterGrayScale";
            this.cbFilterGrayScale.Size = new System.Drawing.Size(73, 17);
            this.cbFilterGrayScale.TabIndex = 0;
            this.cbFilterGrayScale.Text = "Grayscale";
            this.cbFilterGrayScale.UseVisualStyleBackColor = true;
            this.cbFilterGrayScale.CheckedChanged += new System.EventHandler(this.cbFilterGrayScale_CheckedChanged);
            // 
            // gbGrayscale
            // 
            this.gbGrayscale.Controls.Add(this.lblGrayCrValue);
            this.gbGrayscale.Controls.Add(this.lblGrayCgValue);
            this.gbGrayscale.Controls.Add(this.lblGrayCbValue);
            this.gbGrayscale.Controls.Add(this.tBarGrayCb);
            this.gbGrayscale.Controls.Add(this.tBarGrayCg);
            this.gbGrayscale.Controls.Add(this.tBarGrayCr);
            this.gbGrayscale.Controls.Add(this.checkBox1);
            this.gbGrayscale.Controls.Add(this.label8);
            this.gbGrayscale.Controls.Add(this.label6);
            this.gbGrayscale.Controls.Add(this.label7);
            this.gbGrayscale.Enabled = false;
            this.gbGrayscale.Location = new System.Drawing.Point(138, 12);
            this.gbGrayscale.Name = "gbGrayscale";
            this.gbGrayscale.Size = new System.Drawing.Size(373, 173);
            this.gbGrayscale.TabIndex = 1;
            this.gbGrayscale.TabStop = false;
            this.gbGrayscale.Text = "Grayscale";
            // 
            // lblGrayCrValue
            // 
            this.lblGrayCrValue.AutoSize = true;
            this.lblGrayCrValue.Location = new System.Drawing.Point(320, 34);
            this.lblGrayCrValue.Name = "lblGrayCrValue";
            this.lblGrayCrValue.Size = new System.Drawing.Size(34, 13);
            this.lblGrayCrValue.TabIndex = 35;
            this.lblGrayCrValue.Text = "Value";
            // 
            // lblGrayCgValue
            // 
            this.lblGrayCgValue.AutoSize = true;
            this.lblGrayCgValue.Location = new System.Drawing.Point(320, 70);
            this.lblGrayCgValue.Name = "lblGrayCgValue";
            this.lblGrayCgValue.Size = new System.Drawing.Size(34, 13);
            this.lblGrayCgValue.TabIndex = 34;
            this.lblGrayCgValue.Text = "Value";
            // 
            // lblGrayCbValue
            // 
            this.lblGrayCbValue.AutoSize = true;
            this.lblGrayCbValue.Location = new System.Drawing.Point(320, 106);
            this.lblGrayCbValue.Name = "lblGrayCbValue";
            this.lblGrayCbValue.Size = new System.Drawing.Size(34, 13);
            this.lblGrayCbValue.TabIndex = 33;
            this.lblGrayCbValue.Text = "Value";
            // 
            // tBarGrayCb
            // 
            this.tBarGrayCb.Location = new System.Drawing.Point(48, 94);
            this.tBarGrayCb.Name = "tBarGrayCb";
            this.tBarGrayCb.Size = new System.Drawing.Size(266, 45);
            this.tBarGrayCb.TabIndex = 32;
            this.tBarGrayCb.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.tBarGrayCb.Scroll += new System.EventHandler(this.tBarGrayCb_Scroll);
            // 
            // tBarGrayCg
            // 
            this.tBarGrayCg.Location = new System.Drawing.Point(48, 57);
            this.tBarGrayCg.Name = "tBarGrayCg";
            this.tBarGrayCg.Size = new System.Drawing.Size(266, 45);
            this.tBarGrayCg.TabIndex = 31;
            this.tBarGrayCg.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.tBarGrayCg.Scroll += new System.EventHandler(this.tBarGrayCg_Scroll);
            // 
            // tBarGrayCr
            // 
            this.tBarGrayCr.Location = new System.Drawing.Point(48, 21);
            this.tBarGrayCr.Name = "tBarGrayCr";
            this.tBarGrayCr.Size = new System.Drawing.Size(266, 45);
            this.tBarGrayCr.TabIndex = 30;
            this.tBarGrayCr.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.tBarGrayCr.Scroll += new System.EventHandler(this.tBarGrayCr_Scroll);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(20, 142);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(124, 17);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "Use Common BT709";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Cb:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Cg:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Cr:";
            // 
            // gbChannel
            // 
            this.gbChannel.Controls.Add(this.rbChannelRed);
            this.gbChannel.Controls.Add(this.rbChannelBlue);
            this.gbChannel.Controls.Add(this.rbChannelGreen);
            this.gbChannel.Enabled = false;
            this.gbChannel.Location = new System.Drawing.Point(138, 405);
            this.gbChannel.Name = "gbChannel";
            this.gbChannel.Size = new System.Drawing.Size(370, 60);
            this.gbChannel.TabIndex = 3;
            this.gbChannel.TabStop = false;
            this.gbChannel.Text = "Channel";
            // 
            // rbChannelRed
            // 
            this.rbChannelRed.AutoSize = true;
            this.rbChannelRed.Location = new System.Drawing.Point(24, 19);
            this.rbChannelRed.Name = "rbChannelRed";
            this.rbChannelRed.Size = new System.Drawing.Size(45, 17);
            this.rbChannelRed.TabIndex = 2;
            this.rbChannelRed.TabStop = true;
            this.rbChannelRed.Text = "Red";
            this.rbChannelRed.UseVisualStyleBackColor = true;
            this.rbChannelRed.CheckedChanged += new System.EventHandler(this.rbChannelRed_CheckedChanged);
            // 
            // rbChannelBlue
            // 
            this.rbChannelBlue.AutoSize = true;
            this.rbChannelBlue.Location = new System.Drawing.Point(177, 20);
            this.rbChannelBlue.Name = "rbChannelBlue";
            this.rbChannelBlue.Size = new System.Drawing.Size(46, 17);
            this.rbChannelBlue.TabIndex = 1;
            this.rbChannelBlue.TabStop = true;
            this.rbChannelBlue.Text = "Blue";
            this.rbChannelBlue.UseVisualStyleBackColor = true;
            this.rbChannelBlue.CheckedChanged += new System.EventHandler(this.rbChannelBlue_CheckedChanged);
            // 
            // rbChannelGreen
            // 
            this.rbChannelGreen.AutoSize = true;
            this.rbChannelGreen.Location = new System.Drawing.Point(96, 20);
            this.rbChannelGreen.Name = "rbChannelGreen";
            this.rbChannelGreen.Size = new System.Drawing.Size(54, 17);
            this.rbChannelGreen.TabIndex = 0;
            this.rbChannelGreen.TabStop = true;
            this.rbChannelGreen.Text = "Green";
            this.rbChannelGreen.UseVisualStyleBackColor = true;
            this.rbChannelGreen.CheckedChanged += new System.EventHandler(this.rbChannelGreen_CheckedChanged);
            // 
            // gbEuc
            // 
            this.gbEuc.Controls.Add(this.lblColor);
            this.gbEuc.Controls.Add(this.cbFillOutSide);
            this.gbEuc.Controls.Add(this.lblEucGreenValue);
            this.gbEuc.Controls.Add(this.lblEucBlueValue);
            this.gbEuc.Controls.Add(this.lblEucRadValue);
            this.gbEuc.Controls.Add(this.lblEucValue);
            this.gbEuc.Controls.Add(this.tBarEucRa);
            this.gbEuc.Controls.Add(this.label3);
            this.gbEuc.Controls.Add(this.tBarEucBlue);
            this.gbEuc.Controls.Add(this.label2);
            this.gbEuc.Controls.Add(this.tBarEucGreen);
            this.gbEuc.Controls.Add(this.label1);
            this.gbEuc.Controls.Add(this.tBarEucRed);
            this.gbEuc.Controls.Add(this.label10);
            this.gbEuc.Enabled = false;
            this.gbEuc.Location = new System.Drawing.Point(523, 14);
            this.gbEuc.Name = "gbEuc";
            this.gbEuc.Size = new System.Drawing.Size(370, 197);
            this.gbEuc.TabIndex = 9;
            this.gbEuc.TabStop = false;
            this.gbEuc.Text = "Euclidian";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.BackColor = System.Drawing.Color.Red;
            this.lblColor.ForeColor = System.Drawing.Color.White;
            this.lblColor.Location = new System.Drawing.Point(301, 158);
            this.lblColor.MinimumSize = new System.Drawing.Size(50, 25);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(50, 25);
            this.lblColor.TabIndex = 32;
            // 
            // cbFillOutSide
            // 
            this.cbFillOutSide.AutoSize = true;
            this.cbFillOutSide.Location = new System.Drawing.Point(12, 174);
            this.cbFillOutSide.Name = "cbFillOutSide";
            this.cbFillOutSide.Size = new System.Drawing.Size(79, 17);
            this.cbFillOutSide.TabIndex = 30;
            this.cbFillOutSide.Text = "Fill OutSide";
            this.cbFillOutSide.UseVisualStyleBackColor = true;
            this.cbFillOutSide.CheckedChanged += new System.EventHandler(this.cbFillOutSide_CheckedChanged);
            // 
            // lblEucGreenValue
            // 
            this.lblEucGreenValue.AutoSize = true;
            this.lblEucGreenValue.Location = new System.Drawing.Point(317, 64);
            this.lblEucGreenValue.Name = "lblEucGreenValue";
            this.lblEucGreenValue.Size = new System.Drawing.Size(34, 13);
            this.lblEucGreenValue.TabIndex = 29;
            this.lblEucGreenValue.Text = "Value";
            // 
            // lblEucBlueValue
            // 
            this.lblEucBlueValue.AutoSize = true;
            this.lblEucBlueValue.Location = new System.Drawing.Point(317, 100);
            this.lblEucBlueValue.Name = "lblEucBlueValue";
            this.lblEucBlueValue.Size = new System.Drawing.Size(34, 13);
            this.lblEucBlueValue.TabIndex = 28;
            this.lblEucBlueValue.Text = "Value";
            // 
            // lblEucRadValue
            // 
            this.lblEucRadValue.AutoSize = true;
            this.lblEucRadValue.Location = new System.Drawing.Point(317, 136);
            this.lblEucRadValue.Name = "lblEucRadValue";
            this.lblEucRadValue.Size = new System.Drawing.Size(34, 13);
            this.lblEucRadValue.TabIndex = 27;
            this.lblEucRadValue.Text = "Value";
            // 
            // lblEucValue
            // 
            this.lblEucValue.AutoSize = true;
            this.lblEucValue.Location = new System.Drawing.Point(317, 28);
            this.lblEucValue.Name = "lblEucValue";
            this.lblEucValue.Size = new System.Drawing.Size(34, 13);
            this.lblEucValue.TabIndex = 26;
            this.lblEucValue.Text = "Value";
            // 
            // tBarEucRa
            // 
            this.tBarEucRa.Location = new System.Drawing.Point(45, 124);
            this.tBarEucRa.Name = "tBarEucRa";
            this.tBarEucRa.Size = new System.Drawing.Size(266, 45);
            this.tBarEucRa.TabIndex = 25;
            this.tBarEucRa.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.tBarEucRa.Scroll += new System.EventHandler(this.tBarEucRa_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Radius:";
            // 
            // tBarEucBlue
            // 
            this.tBarEucBlue.Location = new System.Drawing.Point(45, 87);
            this.tBarEucBlue.Name = "tBarEucBlue";
            this.tBarEucBlue.Size = new System.Drawing.Size(266, 45);
            this.tBarEucBlue.TabIndex = 23;
            this.tBarEucBlue.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.tBarEucBlue.Scroll += new System.EventHandler(this.tBarEucBlue_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Blue:";
            // 
            // tBarEucGreen
            // 
            this.tBarEucGreen.Location = new System.Drawing.Point(45, 51);
            this.tBarEucGreen.Name = "tBarEucGreen";
            this.tBarEucGreen.Size = new System.Drawing.Size(266, 45);
            this.tBarEucGreen.TabIndex = 21;
            this.tBarEucGreen.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.tBarEucGreen.Scroll += new System.EventHandler(this.tBarEucGreen_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Green:";
            // 
            // tBarEucRed
            // 
            this.tBarEucRed.Location = new System.Drawing.Point(45, 15);
            this.tBarEucRed.Name = "tBarEucRed";
            this.tBarEucRed.Size = new System.Drawing.Size(266, 45);
            this.tBarEucRed.TabIndex = 19;
            this.tBarEucRed.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.tBarEucRed.Scroll += new System.EventHandler(this.tBarEucRed_Scroll);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Red:";
            // 
            // gbThress
            // 
            this.gbThress.Controls.Add(this.lblThresValue);
            this.gbThress.Controls.Add(this.tBarThres);
            this.gbThress.Enabled = false;
            this.gbThress.Location = new System.Drawing.Point(138, 194);
            this.gbThress.Name = "gbThress";
            this.gbThress.Size = new System.Drawing.Size(373, 63);
            this.gbThress.TabIndex = 12;
            this.gbThress.TabStop = false;
            this.gbThress.Text = "Threshold";
            // 
            // lblThresValue
            // 
            this.lblThresValue.AutoSize = true;
            this.lblThresValue.Location = new System.Drawing.Point(320, 24);
            this.lblThresValue.Name = "lblThresValue";
            this.lblThresValue.Size = new System.Drawing.Size(34, 13);
            this.lblThresValue.TabIndex = 36;
            this.lblThresValue.Text = "Value";
            // 
            // tBarThres
            // 
            this.tBarThres.Location = new System.Drawing.Point(48, 12);
            this.tBarThres.Name = "tBarThres";
            this.tBarThres.Size = new System.Drawing.Size(266, 45);
            this.tBarThres.TabIndex = 15;
            this.tBarThres.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.tBarThres.Scroll += new System.EventHandler(this.tBarThres_Scroll);
            // 
            // gbBrightness
            // 
            this.gbBrightness.Controls.Add(this.lblBrithValue);
            this.gbBrightness.Controls.Add(this.tBarBrightness);
            this.gbBrightness.Enabled = false;
            this.gbBrightness.Location = new System.Drawing.Point(138, 260);
            this.gbBrightness.Name = "gbBrightness";
            this.gbBrightness.Size = new System.Drawing.Size(370, 60);
            this.gbBrightness.TabIndex = 4;
            this.gbBrightness.TabStop = false;
            this.gbBrightness.Text = "Brightness";
            // 
            // lblBrithValue
            // 
            this.lblBrithValue.AutoSize = true;
            this.lblBrithValue.Location = new System.Drawing.Point(317, 23);
            this.lblBrithValue.Name = "lblBrithValue";
            this.lblBrithValue.Size = new System.Drawing.Size(34, 13);
            this.lblBrithValue.TabIndex = 30;
            this.lblBrithValue.Text = "Value";
            // 
            // tBarBrightness
            // 
            this.tBarBrightness.Location = new System.Drawing.Point(45, 14);
            this.tBarBrightness.Name = "tBarBrightness";
            this.tBarBrightness.Size = new System.Drawing.Size(266, 45);
            this.tBarBrightness.TabIndex = 14;
            this.tBarBrightness.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.tBarBrightness.Scroll += new System.EventHandler(this.tBarBrightness_Scroll);
            // 
            // gbNoise
            // 
            this.gbNoise.Controls.Add(this.lblConsValue);
            this.gbNoise.Controls.Add(this.tBarCons);
            this.gbNoise.Enabled = false;
            this.gbNoise.Location = new System.Drawing.Point(141, 471);
            this.gbNoise.Name = "gbNoise";
            this.gbNoise.Size = new System.Drawing.Size(370, 63);
            this.gbNoise.TabIndex = 4;
            this.gbNoise.TabStop = false;
            this.gbNoise.Text = "Noise Redu Kernel";
            // 
            // lblConsValue
            // 
            this.lblConsValue.AutoSize = true;
            this.lblConsValue.Location = new System.Drawing.Point(317, 26);
            this.lblConsValue.Name = "lblConsValue";
            this.lblConsValue.Size = new System.Drawing.Size(34, 13);
            this.lblConsValue.TabIndex = 38;
            this.lblConsValue.Text = "Value";
            // 
            // tBarCons
            // 
            this.tBarCons.Location = new System.Drawing.Point(45, 14);
            this.tBarCons.Name = "tBarCons";
            this.tBarCons.Size = new System.Drawing.Size(266, 45);
            this.tBarCons.TabIndex = 37;
            this.tBarCons.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.tBarCons.Scroll += new System.EventHandler(this.tBarCons_Scroll);
            // 
            // gbGamma
            // 
            this.gbGamma.Controls.Add(this.lblGammaValue);
            this.gbGamma.Controls.Add(this.tBarGamma);
            this.gbGamma.Enabled = false;
            this.gbGamma.Location = new System.Drawing.Point(138, 325);
            this.gbGamma.Name = "gbGamma";
            this.gbGamma.Size = new System.Drawing.Size(370, 74);
            this.gbGamma.TabIndex = 5;
            this.gbGamma.TabStop = false;
            this.gbGamma.Text = "Gamma";
            // 
            // lblGammaValue
            // 
            this.lblGammaValue.AutoSize = true;
            this.lblGammaValue.Location = new System.Drawing.Point(317, 27);
            this.lblGammaValue.Name = "lblGammaValue";
            this.lblGammaValue.Size = new System.Drawing.Size(34, 13);
            this.lblGammaValue.TabIndex = 31;
            this.lblGammaValue.Text = "Value";
            // 
            // tBarGamma
            // 
            this.tBarGamma.Location = new System.Drawing.Point(45, 14);
            this.tBarGamma.Name = "tBarGamma";
            this.tBarGamma.Size = new System.Drawing.Size(266, 45);
            this.tBarGamma.TabIndex = 15;
            this.tBarGamma.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.tBarGamma.Scroll += new System.EventHandler(this.tBarGamma_Scroll);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 634);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(235, 45);
            this.button1.TabIndex = 13;
            this.button1.Text = "Einstellungen übernehmen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gbCanny
            // 
            this.gbCanny.Controls.Add(this.lblCanGausValue);
            this.gbCanny.Controls.Add(this.lblCanHThresValue);
            this.gbCanny.Controls.Add(this.lblCanLThresValue);
            this.gbCanny.Controls.Add(this.lblCanSigmaValue);
            this.gbCanny.Controls.Add(this.tBarCanLThres);
            this.gbCanny.Controls.Add(this.label15);
            this.gbCanny.Controls.Add(this.tBarCanHThres);
            this.gbCanny.Controls.Add(this.label16);
            this.gbCanny.Controls.Add(this.tBarCanGaus);
            this.gbCanny.Controls.Add(this.label17);
            this.gbCanny.Controls.Add(this.tBarCanSig);
            this.gbCanny.Controls.Add(this.label18);
            this.gbCanny.Enabled = false;
            this.gbCanny.Location = new System.Drawing.Point(523, 216);
            this.gbCanny.Name = "gbCanny";
            this.gbCanny.Size = new System.Drawing.Size(370, 174);
            this.gbCanny.TabIndex = 30;
            this.gbCanny.TabStop = false;
            this.gbCanny.Text = "Canny";
            // 
            // lblCanGausValue
            // 
            this.lblCanGausValue.AutoSize = true;
            this.lblCanGausValue.Location = new System.Drawing.Point(317, 64);
            this.lblCanGausValue.Name = "lblCanGausValue";
            this.lblCanGausValue.Size = new System.Drawing.Size(34, 13);
            this.lblCanGausValue.TabIndex = 29;
            this.lblCanGausValue.Text = "Value";
            // 
            // lblCanHThresValue
            // 
            this.lblCanHThresValue.AutoSize = true;
            this.lblCanHThresValue.Location = new System.Drawing.Point(317, 100);
            this.lblCanHThresValue.Name = "lblCanHThresValue";
            this.lblCanHThresValue.Size = new System.Drawing.Size(34, 13);
            this.lblCanHThresValue.TabIndex = 28;
            this.lblCanHThresValue.Text = "Value";
            // 
            // lblCanLThresValue
            // 
            this.lblCanLThresValue.AutoSize = true;
            this.lblCanLThresValue.Location = new System.Drawing.Point(317, 136);
            this.lblCanLThresValue.Name = "lblCanLThresValue";
            this.lblCanLThresValue.Size = new System.Drawing.Size(34, 13);
            this.lblCanLThresValue.TabIndex = 27;
            this.lblCanLThresValue.Text = "Value";
            // 
            // lblCanSigmaValue
            // 
            this.lblCanSigmaValue.AutoSize = true;
            this.lblCanSigmaValue.Location = new System.Drawing.Point(317, 28);
            this.lblCanSigmaValue.Name = "lblCanSigmaValue";
            this.lblCanSigmaValue.Size = new System.Drawing.Size(34, 13);
            this.lblCanSigmaValue.TabIndex = 26;
            this.lblCanSigmaValue.Text = "Value";
            // 
            // tBarCanLThres
            // 
            this.tBarCanLThres.Location = new System.Drawing.Point(45, 124);
            this.tBarCanLThres.Name = "tBarCanLThres";
            this.tBarCanLThres.Size = new System.Drawing.Size(266, 45);
            this.tBarCanLThres.TabIndex = 25;
            this.tBarCanLThres.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.tBarCanLThres.Scroll += new System.EventHandler(this.tBarCanLThres_Scroll);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 137);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 13);
            this.label15.TabIndex = 24;
            this.label15.Text = "LThre";
            // 
            // tBarCanHThres
            // 
            this.tBarCanHThres.Location = new System.Drawing.Point(45, 87);
            this.tBarCanHThres.Name = "tBarCanHThres";
            this.tBarCanHThres.Size = new System.Drawing.Size(266, 45);
            this.tBarCanHThres.TabIndex = 23;
            this.tBarCanHThres.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.tBarCanHThres.Scroll += new System.EventHandler(this.tBarCanHThres_Scroll);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(9, 100);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(42, 13);
            this.label16.TabIndex = 22;
            this.label16.Text = "HThres";
            // 
            // tBarCanGaus
            // 
            this.tBarCanGaus.Location = new System.Drawing.Point(45, 51);
            this.tBarCanGaus.Name = "tBarCanGaus";
            this.tBarCanGaus.Size = new System.Drawing.Size(266, 45);
            this.tBarCanGaus.TabIndex = 21;
            this.tBarCanGaus.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.tBarCanGaus.Scroll += new System.EventHandler(this.tBarCanGaus_Scroll);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(9, 64);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(32, 13);
            this.label17.TabIndex = 20;
            this.label17.Text = "Gaus";
            // 
            // tBarCanSig
            // 
            this.tBarCanSig.Location = new System.Drawing.Point(45, 15);
            this.tBarCanSig.Name = "tBarCanSig";
            this.tBarCanSig.Size = new System.Drawing.Size(266, 45);
            this.tBarCanSig.TabIndex = 19;
            this.tBarCanSig.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.tBarCanSig.Scroll += new System.EventHandler(this.tBarCanSig_Scroll);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(9, 28);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(36, 13);
            this.label18.TabIndex = 10;
            this.label18.Text = "Sigma";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // gbGaussian
            // 
            this.gbGaussian.Controls.Add(this.lblGausKernel);
            this.gbGaussian.Controls.Add(this.lblGausValue);
            this.gbGaussian.Controls.Add(this.tBarGausValue);
            this.gbGaussian.Controls.Add(this.tBarGausKernel);
            this.gbGaussian.Controls.Add(this.label14);
            this.gbGaussian.Controls.Add(this.label19);
            this.gbGaussian.Enabled = false;
            this.gbGaussian.Location = new System.Drawing.Point(899, 14);
            this.gbGaussian.Name = "gbGaussian";
            this.gbGaussian.Size = new System.Drawing.Size(373, 105);
            this.gbGaussian.TabIndex = 36;
            this.gbGaussian.TabStop = false;
            this.gbGaussian.Text = "Gaussian Blur";
            // 
            // lblGausKernel
            // 
            this.lblGausKernel.AutoSize = true;
            this.lblGausKernel.Location = new System.Drawing.Point(320, 34);
            this.lblGausKernel.Name = "lblGausKernel";
            this.lblGausKernel.Size = new System.Drawing.Size(34, 13);
            this.lblGausKernel.TabIndex = 35;
            this.lblGausKernel.Text = "Value";
            // 
            // lblGausValue
            // 
            this.lblGausValue.AutoSize = true;
            this.lblGausValue.Location = new System.Drawing.Point(320, 70);
            this.lblGausValue.Name = "lblGausValue";
            this.lblGausValue.Size = new System.Drawing.Size(34, 13);
            this.lblGausValue.TabIndex = 34;
            this.lblGausValue.Text = "Value";
            // 
            // tBarGausValue
            // 
            this.tBarGausValue.Location = new System.Drawing.Point(48, 57);
            this.tBarGausValue.Name = "tBarGausValue";
            this.tBarGausValue.Size = new System.Drawing.Size(266, 45);
            this.tBarGausValue.TabIndex = 31;
            this.tBarGausValue.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.tBarGausValue.Scroll += new System.EventHandler(this.tBarGausValue_Scroll);
            // 
            // tBarGausKernel
            // 
            this.tBarGausKernel.Location = new System.Drawing.Point(48, 21);
            this.tBarGausKernel.Name = "tBarGausKernel";
            this.tBarGausKernel.Size = new System.Drawing.Size(266, 45);
            this.tBarGausKernel.TabIndex = 30;
            this.tBarGausKernel.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.tBarGausKernel.Scroll += new System.EventHandler(this.tBarGausKernel_Scroll);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 70);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 13);
            this.label14.TabIndex = 17;
            this.label14.Text = "Value";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(13, 35);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(37, 13);
            this.label19.TabIndex = 16;
            this.label19.Text = "Kernel";
            // 
            // gpContour
            // 
            this.gpContour.Controls.Add(this.label21);
            this.gpContour.Controls.Add(this.tbContourDRangeMax);
            this.gpContour.Controls.Add(this.tbContourDRangeMin);
            this.gpContour.Controls.Add(this.lblContourKernel);
            this.gpContour.Controls.Add(this.lblContourSuppresion);
            this.gpContour.Controls.Add(this.lblContourThres);
            this.gpContour.Controls.Add(this.label20);
            this.gpContour.Controls.Add(this.tBarContourSupression);
            this.gpContour.Controls.Add(this.Suspression);
            this.gpContour.Controls.Add(this.tBarContourKernel);
            this.gpContour.Controls.Add(this.Kernel);
            this.gpContour.Controls.Add(this.tBarContourThreshold);
            this.gpContour.Controls.Add(this.label23);
            this.gpContour.Enabled = false;
            this.gpContour.Location = new System.Drawing.Point(899, 122);
            this.gpContour.Name = "gpContour";
            this.gpContour.Size = new System.Drawing.Size(370, 174);
            this.gpContour.TabIndex = 31;
            this.gpContour.TabStop = false;
            this.gpContour.Text = "Contour";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(190, 139);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(27, 13);
            this.label21.TabIndex = 32;
            this.label21.Text = "Max";
            // 
            // tbContourDRangeMax
            // 
            this.tbContourDRangeMax.Location = new System.Drawing.Point(237, 134);
            this.tbContourDRangeMax.Name = "tbContourDRangeMax";
            this.tbContourDRangeMax.Size = new System.Drawing.Size(52, 20);
            this.tbContourDRangeMax.TabIndex = 31;
            this.tbContourDRangeMax.Leave += new System.EventHandler(this.tbContourDRangeMax_Leave);
            // 
            // tbContourDRangeMin
            // 
            this.tbContourDRangeMin.Location = new System.Drawing.Point(123, 134);
            this.tbContourDRangeMin.Name = "tbContourDRangeMin";
            this.tbContourDRangeMin.Size = new System.Drawing.Size(52, 20);
            this.tbContourDRangeMin.TabIndex = 30;
            this.tbContourDRangeMin.Leave += new System.EventHandler(this.tbContourDRangeMin_Leave);
            // 
            // lblContourKernel
            // 
            this.lblContourKernel.AutoSize = true;
            this.lblContourKernel.Location = new System.Drawing.Point(317, 64);
            this.lblContourKernel.Name = "lblContourKernel";
            this.lblContourKernel.Size = new System.Drawing.Size(34, 13);
            this.lblContourKernel.TabIndex = 29;
            this.lblContourKernel.Text = "Value";
            // 
            // lblContourSuppresion
            // 
            this.lblContourSuppresion.AutoSize = true;
            this.lblContourSuppresion.Location = new System.Drawing.Point(317, 100);
            this.lblContourSuppresion.Name = "lblContourSuppresion";
            this.lblContourSuppresion.Size = new System.Drawing.Size(34, 13);
            this.lblContourSuppresion.TabIndex = 28;
            this.lblContourSuppresion.Text = "Value";
            // 
            // lblContourThres
            // 
            this.lblContourThres.AutoSize = true;
            this.lblContourThres.Location = new System.Drawing.Point(317, 28);
            this.lblContourThres.Name = "lblContourThres";
            this.lblContourThres.Size = new System.Drawing.Size(34, 13);
            this.lblContourThres.TabIndex = 26;
            this.lblContourThres.Text = "Value";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(9, 137);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(93, 13);
            this.label20.TabIndex = 24;
            this.label20.Text = "DoubleRange Min";
            // 
            // tBarContourSupression
            // 
            this.tBarContourSupression.Location = new System.Drawing.Point(45, 87);
            this.tBarContourSupression.Name = "tBarContourSupression";
            this.tBarContourSupression.Size = new System.Drawing.Size(266, 45);
            this.tBarContourSupression.TabIndex = 23;
            this.tBarContourSupression.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.tBarContourSupression.Scroll += new System.EventHandler(this.tBarContourSupression_Scroll);
            // 
            // Suspression
            // 
            this.Suspression.AutoSize = true;
            this.Suspression.Location = new System.Drawing.Point(9, 100);
            this.Suspression.Name = "Suspression";
            this.Suspression.Size = new System.Drawing.Size(64, 13);
            this.Suspression.TabIndex = 22;
            this.Suspression.Text = "Suspression";
            // 
            // tBarContourKernel
            // 
            this.tBarContourKernel.Location = new System.Drawing.Point(45, 51);
            this.tBarContourKernel.Name = "tBarContourKernel";
            this.tBarContourKernel.Size = new System.Drawing.Size(266, 45);
            this.tBarContourKernel.TabIndex = 21;
            this.tBarContourKernel.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.tBarContourKernel.Scroll += new System.EventHandler(this.tBarContourKernel_Scroll);
            // 
            // Kernel
            // 
            this.Kernel.AutoSize = true;
            this.Kernel.Location = new System.Drawing.Point(9, 64);
            this.Kernel.Name = "Kernel";
            this.Kernel.Size = new System.Drawing.Size(37, 13);
            this.Kernel.TabIndex = 20;
            this.Kernel.Text = "Kernel";
            // 
            // tBarContourThreshold
            // 
            this.tBarContourThreshold.Location = new System.Drawing.Point(45, 15);
            this.tBarContourThreshold.Name = "tBarContourThreshold";
            this.tBarContourThreshold.Size = new System.Drawing.Size(266, 45);
            this.tBarContourThreshold.TabIndex = 19;
            this.tBarContourThreshold.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.tBarContourThreshold.Scroll += new System.EventHandler(this.tBarContourThreshold_Scroll);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(9, 28);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(34, 13);
            this.label23.TabIndex = 10;
            this.label23.Text = "Thres";
            // 
            // gpFAST
            // 
            this.gpFAST.Controls.Add(this.cbFASTSuppress);
            this.gpFAST.Controls.Add(this.label5);
            this.gpFAST.Controls.Add(this.lblFASTGetValueAvr);
            this.gpFAST.Controls.Add(this.tBarFASTThres);
            this.gpFAST.Enabled = false;
            this.gpFAST.Location = new System.Drawing.Point(523, 585);
            this.gpFAST.Name = "gpFAST";
            this.gpFAST.Size = new System.Drawing.Size(370, 81);
            this.gpFAST.TabIndex = 39;
            this.gpFAST.TabStop = false;
            this.gpFAST.Text = "FAST Detection";
            // 
            // cbFASTSuppress
            // 
            this.cbFASTSuppress.AutoSize = true;
            this.cbFASTSuppress.Location = new System.Drawing.Point(20, 58);
            this.cbFASTSuppress.Name = "cbFASTSuppress";
            this.cbFASTSuppress.Size = new System.Drawing.Size(84, 17);
            this.cbFASTSuppress.TabIndex = 36;
            this.cbFASTSuppress.Text = "Suppression";
            this.cbFASTSuppress.UseVisualStyleBackColor = true;
            this.cbFASTSuppress.CheckedChanged += new System.EventHandler(this.cbFASTSuppress_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Thres";
            // 
            // lblFASTGetValueAvr
            // 
            this.lblFASTGetValueAvr.AutoSize = true;
            this.lblFASTGetValueAvr.Location = new System.Drawing.Point(317, 26);
            this.lblFASTGetValueAvr.Name = "lblFASTGetValueAvr";
            this.lblFASTGetValueAvr.Size = new System.Drawing.Size(34, 13);
            this.lblFASTGetValueAvr.TabIndex = 38;
            this.lblFASTGetValueAvr.Text = "Value";
            // 
            // tBarFASTThres
            // 
            this.tBarFASTThres.Location = new System.Drawing.Point(45, 14);
            this.tBarFASTThres.Name = "tBarFASTThres";
            this.tBarFASTThres.Size = new System.Drawing.Size(266, 45);
            this.tBarFASTThres.TabIndex = 37;
            this.tBarFASTThres.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.tBarFASTThres.Scroll += new System.EventHandler(this.tBarFASTThres_Scroll);
            // 
            // gbConv
            // 
            this.gbConv.Controls.Add(this.cbConvDynamic);
            this.gbConv.Controls.Add(this.cbConvProcessAlpha);
            this.gbConv.Controls.Add(this.label4);
            this.gbConv.Controls.Add(this.lblConvValue);
            this.gbConv.Controls.Add(this.tBarConvThres);
            this.gbConv.Enabled = false;
            this.gbConv.Location = new System.Drawing.Point(141, 540);
            this.gbConv.Name = "gbConv";
            this.gbConv.Size = new System.Drawing.Size(370, 81);
            this.gbConv.TabIndex = 40;
            this.gbConv.TabStop = false;
            this.gbConv.Text = "Convolution";
            // 
            // cbConvDynamic
            // 
            this.cbConvDynamic.AutoSize = true;
            this.cbConvDynamic.Location = new System.Drawing.Point(120, 57);
            this.cbConvDynamic.Name = "cbConvDynamic";
            this.cbConvDynamic.Size = new System.Drawing.Size(102, 17);
            this.cbConvDynamic.TabIndex = 40;
            this.cbConvDynamic.Text = "Dynamic Divisor";
            this.cbConvDynamic.UseVisualStyleBackColor = true;
            this.cbConvDynamic.CheckedChanged += new System.EventHandler(this.cbConvDynamic_CheckedChanged);
            // 
            // cbConvProcessAlpha
            // 
            this.cbConvProcessAlpha.AutoSize = true;
            this.cbConvProcessAlpha.Location = new System.Drawing.Point(20, 58);
            this.cbConvProcessAlpha.Name = "cbConvProcessAlpha";
            this.cbConvProcessAlpha.Size = new System.Drawing.Size(94, 17);
            this.cbConvProcessAlpha.TabIndex = 36;
            this.cbConvProcessAlpha.Text = "Process Alpha";
            this.cbConvProcessAlpha.UseVisualStyleBackColor = true;
            this.cbConvProcessAlpha.CheckedChanged += new System.EventHandler(this.cbConvProcessAlpha_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Thres";
            // 
            // lblConvValue
            // 
            this.lblConvValue.AutoSize = true;
            this.lblConvValue.Location = new System.Drawing.Point(317, 26);
            this.lblConvValue.Name = "lblConvValue";
            this.lblConvValue.Size = new System.Drawing.Size(34, 13);
            this.lblConvValue.TabIndex = 38;
            this.lblConvValue.Text = "Value";
            // 
            // tBarConvThres
            // 
            this.tBarConvThres.Location = new System.Drawing.Point(45, 14);
            this.tBarConvThres.Name = "tBarConvThres";
            this.tBarConvThres.Size = new System.Drawing.Size(266, 45);
            this.tBarConvThres.TabIndex = 37;
            this.tBarConvThres.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.tBarConvThres.Scroll += new System.EventHandler(this.tBarConvThres_Scroll);
            // 
            // gbHarrisDetector
            // 
            this.gbHarrisDetector.Controls.Add(this.cbHarrisIsNoble);
            this.gbHarrisDetector.Controls.Add(this.lblHarrisSigmaValue);
            this.gbHarrisDetector.Controls.Add(this.lblHarrisThresValue);
            this.gbHarrisDetector.Controls.Add(this.lblHarrisSupressValue);
            this.gbHarrisDetector.Controls.Add(this.lblHarrisKValue);
            this.gbHarrisDetector.Controls.Add(this.tBarHarristBar);
            this.gbHarrisDetector.Controls.Add(this.tBarHarrisSupress);
            this.gbHarrisDetector.Controls.Add(this.tBarHarrisThres);
            this.gbHarrisDetector.Controls.Add(this.label27);
            this.gbHarrisDetector.Controls.Add(this.tBarHarrisSigma);
            this.gbHarrisDetector.Controls.Add(this.lblddHarrisSigma);
            this.gbHarrisDetector.Controls.Add(this.tBarHarrisK);
            this.gbHarrisDetector.Controls.Add(this.label29);
            this.gbHarrisDetector.Enabled = false;
            this.gbHarrisDetector.Location = new System.Drawing.Point(523, 398);
            this.gbHarrisDetector.Name = "gbHarrisDetector";
            this.gbHarrisDetector.Size = new System.Drawing.Size(370, 181);
            this.gbHarrisDetector.TabIndex = 33;
            this.gbHarrisDetector.TabStop = false;
            this.gbHarrisDetector.Text = "Harris Detector";
            // 
            // cbHarrisIsNoble
            // 
            this.cbHarrisIsNoble.AutoSize = true;
            this.cbHarrisIsNoble.Location = new System.Drawing.Point(12, 161);
            this.cbHarrisIsNoble.Name = "cbHarrisIsNoble";
            this.cbHarrisIsNoble.Size = new System.Drawing.Size(123, 17);
            this.cbHarrisIsNoble.TabIndex = 30;
            this.cbHarrisIsNoble.Text = "CornerMesure Nobel";
            this.cbHarrisIsNoble.UseVisualStyleBackColor = true;
            this.cbHarrisIsNoble.CheckedChanged += new System.EventHandler(this.cbHarrisIsNoble_CheckedChanged);
            // 
            // lblHarrisSigmaValue
            // 
            this.lblHarrisSigmaValue.AutoSize = true;
            this.lblHarrisSigmaValue.Location = new System.Drawing.Point(317, 64);
            this.lblHarrisSigmaValue.Name = "lblHarrisSigmaValue";
            this.lblHarrisSigmaValue.Size = new System.Drawing.Size(34, 13);
            this.lblHarrisSigmaValue.TabIndex = 29;
            this.lblHarrisSigmaValue.Text = "Value";
            // 
            // lblHarrisThresValue
            // 
            this.lblHarrisThresValue.AutoSize = true;
            this.lblHarrisThresValue.Location = new System.Drawing.Point(317, 100);
            this.lblHarrisThresValue.Name = "lblHarrisThresValue";
            this.lblHarrisThresValue.Size = new System.Drawing.Size(34, 13);
            this.lblHarrisThresValue.TabIndex = 28;
            this.lblHarrisThresValue.Text = "Value";
            // 
            // lblHarrisSupressValue
            // 
            this.lblHarrisSupressValue.AutoSize = true;
            this.lblHarrisSupressValue.Location = new System.Drawing.Point(317, 136);
            this.lblHarrisSupressValue.Name = "lblHarrisSupressValue";
            this.lblHarrisSupressValue.Size = new System.Drawing.Size(34, 13);
            this.lblHarrisSupressValue.TabIndex = 27;
            this.lblHarrisSupressValue.Text = "Value";
            // 
            // lblHarrisKValue
            // 
            this.lblHarrisKValue.AutoSize = true;
            this.lblHarrisKValue.Location = new System.Drawing.Point(317, 28);
            this.lblHarrisKValue.Name = "lblHarrisKValue";
            this.lblHarrisKValue.Size = new System.Drawing.Size(34, 13);
            this.lblHarrisKValue.TabIndex = 26;
            this.lblHarrisKValue.Text = "Value";
            // 
            // tBarHarristBar
            // 
            this.tBarHarristBar.Location = new System.Drawing.Point(45, 124);
            this.tBarHarristBar.Name = "tBarHarristBar";
            this.tBarHarristBar.Size = new System.Drawing.Size(266, 45);
            this.tBarHarristBar.TabIndex = 25;
            this.tBarHarristBar.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.tBarHarristBar.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // tBarHarrisSupress
            // 
            this.tBarHarrisSupress.AutoSize = true;
            this.tBarHarrisSupress.Location = new System.Drawing.Point(9, 137);
            this.tBarHarrisSupress.Name = "tBarHarrisSupress";
            this.tBarHarrisSupress.Size = new System.Drawing.Size(59, 13);
            this.tBarHarrisSupress.TabIndex = 24;
            this.tBarHarrisSupress.Text = "Supression";
            // 
            // tBarHarrisThres
            // 
            this.tBarHarrisThres.Location = new System.Drawing.Point(45, 87);
            this.tBarHarrisThres.Name = "tBarHarrisThres";
            this.tBarHarrisThres.Size = new System.Drawing.Size(266, 45);
            this.tBarHarrisThres.TabIndex = 23;
            this.tBarHarrisThres.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.tBarHarrisThres.Scroll += new System.EventHandler(this.tBarHarrisThres_Scroll);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(9, 100);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(34, 13);
            this.label27.TabIndex = 22;
            this.label27.Text = "Thres";
            // 
            // tBarHarrisSigma
            // 
            this.tBarHarrisSigma.Location = new System.Drawing.Point(45, 51);
            this.tBarHarrisSigma.Name = "tBarHarrisSigma";
            this.tBarHarrisSigma.Size = new System.Drawing.Size(266, 45);
            this.tBarHarrisSigma.TabIndex = 21;
            this.tBarHarrisSigma.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.tBarHarrisSigma.Scroll += new System.EventHandler(this.tBarHarrisSigma_Scroll);
            // 
            // lblddHarrisSigma
            // 
            this.lblddHarrisSigma.AutoSize = true;
            this.lblddHarrisSigma.Location = new System.Drawing.Point(9, 64);
            this.lblddHarrisSigma.Name = "lblddHarrisSigma";
            this.lblddHarrisSigma.Size = new System.Drawing.Size(36, 13);
            this.lblddHarrisSigma.TabIndex = 20;
            this.lblddHarrisSigma.Text = "Sigma";
            // 
            // tBarHarrisK
            // 
            this.tBarHarrisK.Location = new System.Drawing.Point(45, 15);
            this.tBarHarrisK.Name = "tBarHarrisK";
            this.tBarHarrisK.Size = new System.Drawing.Size(266, 45);
            this.tBarHarrisK.TabIndex = 19;
            this.tBarHarrisK.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.tBarHarrisK.Scroll += new System.EventHandler(this.tBarHarrisK_Scroll);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(9, 28);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(14, 13);
            this.label29.TabIndex = 10;
            this.label29.Text = "K";
            // 
            // gbSobel
            // 
            this.gbSobel.Controls.Add(this.cbSolbelScaleIntens);
            this.gbSobel.Enabled = false;
            this.gbSobel.Location = new System.Drawing.Point(13, 481);
            this.gbSobel.Name = "gbSobel";
            this.gbSobel.Size = new System.Drawing.Size(119, 62);
            this.gbSobel.TabIndex = 40;
            this.gbSobel.TabStop = false;
            this.gbSobel.Text = "Sobel Edge";
            // 
            // cbSolbelScaleIntens
            // 
            this.cbSolbelScaleIntens.AutoSize = true;
            this.cbSolbelScaleIntens.Location = new System.Drawing.Point(11, 28);
            this.cbSolbelScaleIntens.Name = "cbSolbelScaleIntens";
            this.cbSolbelScaleIntens.Size = new System.Drawing.Size(76, 17);
            this.cbSolbelScaleIntens.TabIndex = 36;
            this.cbSolbelScaleIntens.Text = "ScaleIntes";
            this.cbSolbelScaleIntens.UseVisualStyleBackColor = true;
            this.cbSolbelScaleIntens.CheckedChanged += new System.EventHandler(this.cbSolbelScaleIntens_CheckedChanged);
            // 
            // gBSurf
            // 
            this.gBSurf.Controls.Add(this.label22);
            this.gBSurf.Controls.Add(this.rbSURFDTNone);
            this.gBSurf.Controls.Add(this.rdSURFDTStandard);
            this.gBSurf.Controls.Add(this.cbSURFCompute);
            this.gBSurf.Controls.Add(this.rbSURFDTExtended);
            this.gBSurf.Controls.Add(this.lblSURFThres);
            this.gBSurf.Controls.Add(this.lblSURFStep);
            this.gBSurf.Controls.Add(this.lblSURFOctave);
            this.gBSurf.Controls.Add(this.tBarSURFStep);
            this.gBSurf.Controls.Add(this.label26);
            this.gBSurf.Controls.Add(this.tBarSURFThres);
            this.gBSurf.Controls.Add(this.label28);
            this.gBSurf.Controls.Add(this.tBarSURFOctaves);
            this.gBSurf.Controls.Add(this.label30);
            this.gBSurf.Enabled = false;
            this.gBSurf.Location = new System.Drawing.Point(899, 300);
            this.gBSurf.Name = "gBSurf";
            this.gBSurf.Size = new System.Drawing.Size(370, 181);
            this.gBSurf.TabIndex = 34;
            this.gBSurf.TabStop = false;
            this.gBSurf.Text = "SURF Detector";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(152, 128);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(77, 13);
            this.label22.TabIndex = 31;
            this.label22.Text = "DescrptorType";
            // 
            // rbSURFDTNone
            // 
            this.rbSURFDTNone.AutoSize = true;
            this.rbSURFDTNone.Location = new System.Drawing.Point(155, 151);
            this.rbSURFDTNone.Name = "rbSURFDTNone";
            this.rbSURFDTNone.Size = new System.Drawing.Size(51, 17);
            this.rbSURFDTNone.TabIndex = 5;
            this.rbSURFDTNone.TabStop = true;
            this.rbSURFDTNone.Text = "None";
            this.rbSURFDTNone.UseVisualStyleBackColor = true;
            this.rbSURFDTNone.CheckedChanged += new System.EventHandler(this.rbSURFDTNone_CheckedChanged);
            // 
            // rdSURFDTStandard
            // 
            this.rdSURFDTStandard.AutoSize = true;
            this.rdSURFDTStandard.Location = new System.Drawing.Point(308, 152);
            this.rdSURFDTStandard.Name = "rdSURFDTStandard";
            this.rdSURFDTStandard.Size = new System.Drawing.Size(68, 17);
            this.rdSURFDTStandard.TabIndex = 4;
            this.rdSURFDTStandard.TabStop = true;
            this.rdSURFDTStandard.Text = "Standard";
            this.rdSURFDTStandard.UseVisualStyleBackColor = true;
            this.rdSURFDTStandard.CheckedChanged += new System.EventHandler(this.rdSURFDTStandard_CheckedChanged);
            // 
            // cbSURFCompute
            // 
            this.cbSURFCompute.AutoSize = true;
            this.cbSURFCompute.Location = new System.Drawing.Point(12, 132);
            this.cbSURFCompute.Name = "cbSURFCompute";
            this.cbSURFCompute.Size = new System.Drawing.Size(122, 17);
            this.cbSURFCompute.TabIndex = 30;
            this.cbSURFCompute.Text = "Compute Orientation";
            this.cbSURFCompute.UseVisualStyleBackColor = true;
            this.cbSURFCompute.CheckedChanged += new System.EventHandler(this.cbSURFCompute_CheckedChanged);
            // 
            // rbSURFDTExtended
            // 
            this.rbSURFDTExtended.AutoSize = true;
            this.rbSURFDTExtended.Location = new System.Drawing.Point(227, 152);
            this.rbSURFDTExtended.Name = "rbSURFDTExtended";
            this.rbSURFDTExtended.Size = new System.Drawing.Size(70, 17);
            this.rbSURFDTExtended.TabIndex = 3;
            this.rbSURFDTExtended.TabStop = true;
            this.rbSURFDTExtended.Text = "Extended";
            this.rbSURFDTExtended.UseVisualStyleBackColor = true;
            this.rbSURFDTExtended.CheckedChanged += new System.EventHandler(this.rbSURFDTExtended_CheckedChanged);
            // 
            // lblSURFThres
            // 
            this.lblSURFThres.AutoSize = true;
            this.lblSURFThres.Location = new System.Drawing.Point(317, 64);
            this.lblSURFThres.Name = "lblSURFThres";
            this.lblSURFThres.Size = new System.Drawing.Size(34, 13);
            this.lblSURFThres.TabIndex = 29;
            this.lblSURFThres.Text = "Value";
            // 
            // lblSURFStep
            // 
            this.lblSURFStep.AutoSize = true;
            this.lblSURFStep.Location = new System.Drawing.Point(317, 100);
            this.lblSURFStep.Name = "lblSURFStep";
            this.lblSURFStep.Size = new System.Drawing.Size(34, 13);
            this.lblSURFStep.TabIndex = 28;
            this.lblSURFStep.Text = "Value";
            // 
            // lblSURFOctave
            // 
            this.lblSURFOctave.AutoSize = true;
            this.lblSURFOctave.Location = new System.Drawing.Point(317, 28);
            this.lblSURFOctave.Name = "lblSURFOctave";
            this.lblSURFOctave.Size = new System.Drawing.Size(34, 13);
            this.lblSURFOctave.TabIndex = 26;
            this.lblSURFOctave.Text = "Value";
            // 
            // tBarSURFStep
            // 
            this.tBarSURFStep.Location = new System.Drawing.Point(45, 87);
            this.tBarSURFStep.Name = "tBarSURFStep";
            this.tBarSURFStep.Size = new System.Drawing.Size(266, 45);
            this.tBarSURFStep.TabIndex = 23;
            this.tBarSURFStep.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.tBarSURFStep.Scroll += new System.EventHandler(this.tBarSURFStep_Scroll);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(9, 100);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(29, 13);
            this.label26.TabIndex = 22;
            this.label26.Text = "Step";
            // 
            // tBarSURFThres
            // 
            this.tBarSURFThres.Location = new System.Drawing.Point(45, 51);
            this.tBarSURFThres.Name = "tBarSURFThres";
            this.tBarSURFThres.Size = new System.Drawing.Size(266, 45);
            this.tBarSURFThres.TabIndex = 21;
            this.tBarSURFThres.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.tBarSURFThres.Scroll += new System.EventHandler(this.tBarSURFThres_Scroll);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(9, 64);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(34, 13);
            this.label28.TabIndex = 20;
            this.label28.Text = "Thres";
            // 
            // tBarSURFOctaves
            // 
            this.tBarSURFOctaves.Location = new System.Drawing.Point(45, 15);
            this.tBarSURFOctaves.Name = "tBarSURFOctaves";
            this.tBarSURFOctaves.Size = new System.Drawing.Size(266, 45);
            this.tBarSURFOctaves.TabIndex = 19;
            this.tBarSURFOctaves.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.tBarSURFOctaves.Scroll += new System.EventHandler(this.tBarSURFOctaves_Scroll);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(9, 28);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(47, 13);
            this.label30.TabIndex = 10;
            this.label30.Text = "Octaves";
            // 
            // gbGabor
            // 
            this.gbGabor.Controls.Add(this.label35);
            this.gbGabor.Controls.Add(this.tBarGaborTheta);
            this.gbGabor.Controls.Add(this.lblGaborTheta);
            this.gbGabor.Controls.Add(this.lblGaborGamma);
            this.gbGabor.Controls.Add(this.lblGaborLambda);
            this.gbGabor.Controls.Add(this.lblGaborSigma);
            this.gbGabor.Controls.Add(this.lblGaborSize);
            this.gbGabor.Controls.Add(this.tBarGaborSigma);
            this.gbGabor.Controls.Add(this.label31);
            this.gbGabor.Controls.Add(this.tBarGaborLambda);
            this.gbGabor.Controls.Add(this.label32);
            this.gbGabor.Controls.Add(this.tBarGaborGamma);
            this.gbGabor.Controls.Add(this.label33);
            this.gbGabor.Controls.Add(this.tBarGaborSize);
            this.gbGabor.Controls.Add(this.label34);
            this.gbGabor.Enabled = false;
            this.gbGabor.Location = new System.Drawing.Point(899, 486);
            this.gbGabor.Name = "gbGabor";
            this.gbGabor.Size = new System.Drawing.Size(370, 193);
            this.gbGabor.TabIndex = 31;
            this.gbGabor.TabStop = false;
            this.gbGabor.Text = "GABOR";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(320, 171);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(34, 13);
            this.label35.TabIndex = 32;
            this.label35.Text = "Value";
            // 
            // tBarGaborTheta
            // 
            this.tBarGaborTheta.Location = new System.Drawing.Point(48, 159);
            this.tBarGaborTheta.Name = "tBarGaborTheta";
            this.tBarGaborTheta.Size = new System.Drawing.Size(266, 45);
            this.tBarGaborTheta.TabIndex = 31;
            this.tBarGaborTheta.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.tBarGaborTheta.Scroll += new System.EventHandler(this.tBarGaborTheta_Scroll);
            // 
            // lblGaborTheta
            // 
            this.lblGaborTheta.AutoSize = true;
            this.lblGaborTheta.Location = new System.Drawing.Point(12, 172);
            this.lblGaborTheta.Name = "lblGaborTheta";
            this.lblGaborTheta.Size = new System.Drawing.Size(35, 13);
            this.lblGaborTheta.TabIndex = 30;
            this.lblGaborTheta.Text = "Theta";
            // 
            // lblGaborGamma
            // 
            this.lblGaborGamma.AutoSize = true;
            this.lblGaborGamma.Location = new System.Drawing.Point(317, 64);
            this.lblGaborGamma.Name = "lblGaborGamma";
            this.lblGaborGamma.Size = new System.Drawing.Size(34, 13);
            this.lblGaborGamma.TabIndex = 29;
            this.lblGaborGamma.Text = "Value";
            // 
            // lblGaborLambda
            // 
            this.lblGaborLambda.AutoSize = true;
            this.lblGaborLambda.Location = new System.Drawing.Point(317, 100);
            this.lblGaborLambda.Name = "lblGaborLambda";
            this.lblGaborLambda.Size = new System.Drawing.Size(34, 13);
            this.lblGaborLambda.TabIndex = 28;
            this.lblGaborLambda.Text = "Value";
            // 
            // lblGaborSigma
            // 
            this.lblGaborSigma.AutoSize = true;
            this.lblGaborSigma.Location = new System.Drawing.Point(317, 136);
            this.lblGaborSigma.Name = "lblGaborSigma";
            this.lblGaborSigma.Size = new System.Drawing.Size(34, 13);
            this.lblGaborSigma.TabIndex = 27;
            this.lblGaborSigma.Text = "Value";
            // 
            // lblGaborSize
            // 
            this.lblGaborSize.AutoSize = true;
            this.lblGaborSize.Location = new System.Drawing.Point(317, 28);
            this.lblGaborSize.Name = "lblGaborSize";
            this.lblGaborSize.Size = new System.Drawing.Size(34, 13);
            this.lblGaborSize.TabIndex = 26;
            this.lblGaborSize.Text = "Value";
            // 
            // tBarGaborSigma
            // 
            this.tBarGaborSigma.Location = new System.Drawing.Point(45, 124);
            this.tBarGaborSigma.Name = "tBarGaborSigma";
            this.tBarGaborSigma.Size = new System.Drawing.Size(266, 45);
            this.tBarGaborSigma.TabIndex = 25;
            this.tBarGaborSigma.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.tBarGaborSigma.Scroll += new System.EventHandler(this.tBarGaborSigma_Scroll);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(9, 137);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(36, 13);
            this.label31.TabIndex = 24;
            this.label31.Text = "Sigma";
            // 
            // tBarGaborLambda
            // 
            this.tBarGaborLambda.Location = new System.Drawing.Point(45, 87);
            this.tBarGaborLambda.Name = "tBarGaborLambda";
            this.tBarGaborLambda.Size = new System.Drawing.Size(266, 45);
            this.tBarGaborLambda.TabIndex = 23;
            this.tBarGaborLambda.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.tBarGaborLambda.Scroll += new System.EventHandler(this.tBarGaborLambda_Scroll);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(9, 100);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(39, 13);
            this.label32.TabIndex = 22;
            this.label32.Text = "Lamda";
            // 
            // tBarGaborGamma
            // 
            this.tBarGaborGamma.Location = new System.Drawing.Point(45, 51);
            this.tBarGaborGamma.Name = "tBarGaborGamma";
            this.tBarGaborGamma.Size = new System.Drawing.Size(266, 45);
            this.tBarGaborGamma.TabIndex = 21;
            this.tBarGaborGamma.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.tBarGaborGamma.Scroll += new System.EventHandler(this.tBarGaborGamma_Scroll);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(9, 64);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(43, 13);
            this.label33.TabIndex = 20;
            this.label33.Text = "Gamma";
            // 
            // tBarGaborSize
            // 
            this.tBarGaborSize.Location = new System.Drawing.Point(45, 15);
            this.tBarGaborSize.Name = "tBarGaborSize";
            this.tBarGaborSize.Size = new System.Drawing.Size(266, 45);
            this.tBarGaborSize.TabIndex = 19;
            this.tBarGaborSize.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.tBarGaborSize.Scroll += new System.EventHandler(this.tBarGaborSize_Scroll);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(9, 28);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(27, 13);
            this.label34.TabIndex = 10;
            this.label34.Text = "Size";
            // 
            // FilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1393, 705);
            this.Controls.Add(this.gbGabor);
            this.Controls.Add(this.gBSurf);
            this.Controls.Add(this.gbSobel);
            this.Controls.Add(this.gbHarrisDetector);
            this.Controls.Add(this.gbConv);
            this.Controls.Add(this.gpFAST);
            this.Controls.Add(this.gpContour);
            this.Controls.Add(this.gbGaussian);
            this.Controls.Add(this.gbCanny);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gbGamma);
            this.Controls.Add(this.gbNoise);
            this.Controls.Add(this.gbBrightness);
            this.Controls.Add(this.gbThress);
            this.Controls.Add(this.gbEuc);
            this.Controls.Add(this.gbChannel);
            this.Controls.Add(this.gbGrayscale);
            this.Controls.Add(this.groupBox1);
            this.Name = "FilterForm";
            this.Text = "FilterForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FilterForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbGaussianBlur.ResumeLayout(false);
            this.gbGaussianBlur.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).EndInit();
            this.gbGrayscale.ResumeLayout(false);
            this.gbGrayscale.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBarGrayCb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBarGrayCg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBarGrayCr)).EndInit();
            this.gbChannel.ResumeLayout(false);
            this.gbChannel.PerformLayout();
            this.gbEuc.ResumeLayout(false);
            this.gbEuc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBarEucRa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBarEucBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBarEucGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBarEucRed)).EndInit();
            this.gbThress.ResumeLayout(false);
            this.gbThress.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBarThres)).EndInit();
            this.gbBrightness.ResumeLayout(false);
            this.gbBrightness.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBarBrightness)).EndInit();
            this.gbNoise.ResumeLayout(false);
            this.gbNoise.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBarCons)).EndInit();
            this.gbGamma.ResumeLayout(false);
            this.gbGamma.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBarGamma)).EndInit();
            this.gbCanny.ResumeLayout(false);
            this.gbCanny.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBarCanLThres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBarCanHThres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBarCanGaus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBarCanSig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.gbGaussian.ResumeLayout(false);
            this.gbGaussian.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBarGausValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBarGausKernel)).EndInit();
            this.gpContour.ResumeLayout(false);
            this.gpContour.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBarContourSupression)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBarContourKernel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBarContourThreshold)).EndInit();
            this.gpFAST.ResumeLayout(false);
            this.gpFAST.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBarFASTThres)).EndInit();
            this.gbConv.ResumeLayout(false);
            this.gbConv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBarConvThres)).EndInit();
            this.gbHarrisDetector.ResumeLayout(false);
            this.gbHarrisDetector.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBarHarristBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBarHarrisThres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBarHarrisSigma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBarHarrisK)).EndInit();
            this.gbSobel.ResumeLayout(false);
            this.gbSobel.PerformLayout();
            this.gBSurf.ResumeLayout(false);
            this.gBSurf.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBarSURFStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBarSURFThres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBarSURFOctaves)).EndInit();
            this.gbGabor.ResumeLayout(false);
            this.gbGabor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBarGaborTheta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBarGaborSigma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBarGaborLambda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBarGaborGamma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBarGaborSize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbFilterGrayScale;
        private System.Windows.Forms.CheckBox cbCanny;
        private System.Windows.Forms.CheckBox cbThres;
        private System.Windows.Forms.CheckBox cbSharpen;
        private System.Windows.Forms.CheckBox cbCons;
        private System.Windows.Forms.CheckBox cbEuc;
        private System.Windows.Forms.CheckBox cbInvert;
        private System.Windows.Forms.CheckBox cbChannelExtr;
        private System.Windows.Forms.CheckBox cbGaus;
        private System.Windows.Forms.CheckBox cbContour;
        private System.Windows.Forms.CheckBox cbGamma;
        private System.Windows.Forms.CheckBox cbBrightness;
        private System.Windows.Forms.GroupBox gbGrayscale;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gbChannel;
        private System.Windows.Forms.GroupBox gbGaussianBlur;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox gbEuc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox gbThress;
        private System.Windows.Forms.GroupBox gbBrightness;
        private System.Windows.Forms.GroupBox gbNoise;
        private System.Windows.Forms.GroupBox gbGamma;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RadioButton rbChannelRed;
        private System.Windows.Forms.RadioButton rbChannelBlue;
        private System.Windows.Forms.RadioButton rbChannelGreen;
        private System.Windows.Forms.TrackBar trackBar5;
        private System.Windows.Forms.TrackBar trackBar4;
        private System.Windows.Forms.TrackBar tBarThres;
        private System.Windows.Forms.TrackBar tBarBrightness;
        private System.Windows.Forms.TrackBar tBarGamma;
        private System.Windows.Forms.Label lblEucGreenValue;
        private System.Windows.Forms.Label lblEucBlueValue;
        private System.Windows.Forms.Label lblEucRadValue;
        private System.Windows.Forms.Label lblEucValue;
        private System.Windows.Forms.TrackBar tBarEucRa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar tBarEucBlue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar tBarEucGreen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar tBarEucRed;
        private System.Windows.Forms.GroupBox gbCanny;
        private System.Windows.Forms.Label lblCanGausValue;
        private System.Windows.Forms.Label lblCanHThresValue;
        private System.Windows.Forms.Label lblCanLThresValue;
        private System.Windows.Forms.Label lblCanSigmaValue;
        private System.Windows.Forms.TrackBar tBarCanLThres;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TrackBar tBarCanHThres;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TrackBar tBarCanGaus;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TrackBar tBarCanSig;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblBrithValue;
        private System.Windows.Forms.Label lblGammaValue;
        private System.Windows.Forms.Label lblGrayCrValue;
        private System.Windows.Forms.Label lblGrayCgValue;
        private System.Windows.Forms.Label lblGrayCbValue;
        private System.Windows.Forms.TrackBar tBarGrayCb;
        private System.Windows.Forms.TrackBar tBarGrayCg;
        private System.Windows.Forms.TrackBar tBarGrayCr;
        private System.Windows.Forms.Label lblThresValue;
        private System.Windows.Forms.Label lblConsValue;
        private System.Windows.Forms.TrackBar tBarCons;
        private System.Windows.Forms.CheckBox cbFillOutSide;
        private System.Windows.Forms.Label lblColor;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.CheckBox cbHarrisCornerDetector;
        private System.Windows.Forms.CheckBox cbFastCornerDetector;
        private System.Windows.Forms.CheckBox cbSISThreshold;
        private System.Windows.Forms.CheckBox cbSobel;
        private System.Windows.Forms.CheckBox cbConvolution;
        private System.Windows.Forms.GroupBox gbGaussian;
        private System.Windows.Forms.Label lblGausKernel;
        private System.Windows.Forms.Label lblGausValue;
        private System.Windows.Forms.TrackBar tBarGausValue;
        private System.Windows.Forms.TrackBar tBarGausKernel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox gpContour;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox tbContourDRangeMax;
        private System.Windows.Forms.TextBox tbContourDRangeMin;
        private System.Windows.Forms.Label lblContourKernel;
        private System.Windows.Forms.Label lblContourSuppresion;
        private System.Windows.Forms.Label lblContourThres;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TrackBar tBarContourSupression;
        private System.Windows.Forms.Label Suspression;
        private System.Windows.Forms.TrackBar tBarContourKernel;
        private System.Windows.Forms.Label Kernel;
        private System.Windows.Forms.TrackBar tBarContourThreshold;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.GroupBox gpFAST;
        private System.Windows.Forms.CheckBox cbFASTSuppress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblFASTGetValueAvr;
        private System.Windows.Forms.TrackBar tBarFASTThres;
        private System.Windows.Forms.GroupBox gbConv;
        private System.Windows.Forms.CheckBox cbConvDynamic;
        private System.Windows.Forms.CheckBox cbConvProcessAlpha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblConvValue;
        private System.Windows.Forms.TrackBar tBarConvThres;
        private System.Windows.Forms.GroupBox gbHarrisDetector;
        private System.Windows.Forms.CheckBox cbHarrisIsNoble;
        private System.Windows.Forms.Label lblHarrisSigmaValue;
        private System.Windows.Forms.Label lblHarrisThresValue;
        private System.Windows.Forms.Label lblHarrisSupressValue;
        private System.Windows.Forms.Label lblHarrisKValue;
        private System.Windows.Forms.TrackBar tBarHarristBar;
        private System.Windows.Forms.Label tBarHarrisSupress;
        private System.Windows.Forms.TrackBar tBarHarrisThres;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TrackBar tBarHarrisSigma;
        private System.Windows.Forms.Label lblddHarrisSigma;
        private System.Windows.Forms.TrackBar tBarHarrisK;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.GroupBox gbSobel;
        private System.Windows.Forms.CheckBox cbSolbelScaleIntens;
        private System.Windows.Forms.CheckBox cbSURF;
        private System.Windows.Forms.GroupBox gBSurf;
        private System.Windows.Forms.CheckBox cbSURFCompute;
        private System.Windows.Forms.Label lblSURFThres;
        private System.Windows.Forms.Label lblSURFStep;
        private System.Windows.Forms.Label lblSURFOctave;
        private System.Windows.Forms.TrackBar tBarSURFStep;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TrackBar tBarSURFThres;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TrackBar tBarSURFOctaves;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.RadioButton rbSURFDTNone;
        private System.Windows.Forms.RadioButton rdSURFDTStandard;
        private System.Windows.Forms.RadioButton rbSURFDTExtended;
        private System.Windows.Forms.GroupBox gbGabor;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TrackBar tBarGaborTheta;
        private System.Windows.Forms.Label lblGaborTheta;
        private System.Windows.Forms.Label lblGaborGamma;
        private System.Windows.Forms.Label lblGaborLambda;
        private System.Windows.Forms.Label lblGaborSigma;
        private System.Windows.Forms.Label lblGaborSize;
        private System.Windows.Forms.TrackBar tBarGaborSigma;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TrackBar tBarGaborLambda;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TrackBar tBarGaborGamma;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TrackBar tBarGaborSize;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.CheckBox cbGabor;
    }
}