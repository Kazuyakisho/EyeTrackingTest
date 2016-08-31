// This file has been automatically transcribed by the
//
// Accord Vision Library
// The Accord.NET Framework
// http://accord-framework.net
//

using System.CodeDom.Compiler;
using System.Collections.Generic;
using Accord.Vision.Detection;

namespace EyeTrackingMouseV03Lib.Cascades
{
    /// <summary>
    ///   Automatically generated haar-cascade definition
    ///   to use with the Accord.NET Framework object detectors.
    /// </summary>
    /// 
    [GeneratedCode("Accord.NET HaarCascadeWriter", "2.7")]
    public class haarcascade_mcs_eyepair_big_test : HaarCascade
    {

        /// <summary>
        ///   Automatically generated transcription
        /// </summary>
        public haarcascade_mcs_eyepair_big_test()
            : base(45, 11)
        {
            List<HaarCascadeStage> stages = new List<HaarCascadeStage>();
            List<HaarFeatureNode[]> nodes;
            HaarCascadeStage stage;

            HasTiltedFeatures = true;

            #region Stage 0
            stage = new HaarCascadeStage(-1.4563479423522949, -1, -1); nodes = new List<HaarFeatureNode[]>();
            nodes.Add(new[] { new HaarFeatureNode(0.1012997999787331, -0.7954636812210083, 0.78110837936401367, new int[] { 7, 3, 30, 3, -1 }, new int[] { 17, 3, 10, 3, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0312121100723743, -0.72823482751846313, 0.6224442720413208, new int[] { 34, 5, 11, 6, -1 }, new int[] { 34, 8, 11, 3, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.054906789213419, 0.66794431209564209, -0.60760712623596191, new int[] { 6, 1, 6, 9, -1 }, new int[] { 8, 4, 2, 3, 9 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.131041094660759, -0.48816078901290888, 0.67495757341384888, new int[] { 15, 0, 15, 11, -1 }, new int[] { 20, 0, 5, 11, 3 } ) });
            stage.Trees = nodes.ToArray(); stages.Add(stage);
            #endregion

            #region Stage 1
            stage = new HaarCascadeStage(-1.491752028465271, 0, -1); nodes = new List<HaarFeatureNode[]>();
            nodes.Add(new[] { new HaarFeatureNode(0.15072830021381381, -0.63909012079238892, 0.80536258220672607, new int[] { 7, 3, 30, 3, -1 }, new int[] { 17, 3, 10, 3, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0228874403983355, -0.72313660383224487, 0.39929839968681341, new int[] { 34, 5, 11, 6, -1 }, new int[] { 34, 8, 11, 3, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0276746600866318, -0.70643997192382812, 0.48853880167007452, new int[] { 0, 5, 11, 6, -1 }, new int[] { 0, 8, 11, 3, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0318998582661152, -0.42184171080589289, 0.5392153263092041, new int[] { 22, 0, 6, 11, -1 }, new int[] { 22, 0, 3, 11, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0369728282094002, -0.424006313085556, 0.56811082363128662, new int[] { 17, 0, 6, 11, -1 }, new int[] { 20, 0, 3, 11, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0167110897600651, 0.46170559525489813, -0.42389839887619019, true, new int[] { 39, 0, 1, 9, -1 }, new int[] { 36, 3, 1, 3, 3 } ) });
            stage.Trees = nodes.ToArray(); stages.Add(stage);
            #endregion

            #region Stage 2
            stage = new HaarCascadeStage(-1.682157039642334, 1, -1); nodes = new List<HaarFeatureNode[]>();
            nodes.Add(new[] { new HaarFeatureNode(0.21208600699901581, -0.65022879838943481, 0.59933120012283325, new int[] { 9, 0, 27, 6, -1 }, new int[] { 18, 0, 9, 6, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0227453205734491, 0.51935321092605591, -0.44163998961448669, true, new int[] { 39, 0, 1, 9, -1 }, new int[] { 36, 3, 1, 3, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0215619597584009, -0.64395201206207275, 0.51543998718261719, new int[] { 7, 3, 4, 8, -1 }, new int[] { 7, 7, 4, 4, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0875263586640358, -0.37235569953918463, 0.48228278756141663, new int[] { 17, 2, 12, 8, -1 }, new int[] { 21, 2, 4, 8, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0017132370267063379, -0.62590628862380981, 0.31931561231613159, new int[] { 1, 7, 5, 4, -1 }, new int[] { 1, 9, 5, 2, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.1218293979763985, 0.44271498918533331, -0.28492081165313721, new int[] { 31, 1, 9, 9, -1 }, new int[] { 34, 4, 3, 3, 9 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.016568049788475, 0.43862259387969971, -0.30607050657272339, new int[] { 2, 1, 8, 4, -1 }, new int[] { 2, 3, 8, 2, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0805537775158882, 0.60115402936935425, -0.0198485106229782, new int[] { 18, 2, 12, 9, -1 }, new int[] { 22, 2, 4, 9, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0945484191179276, -0.25033459067344671, 0.480054497718811, new int[] { 15, 2, 12, 9, -1 }, new int[] { 19, 2, 4, 9, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0096633229404687881, 0.21125659346580511, -0.25508201122283941, new int[] { 31, 4, 9, 3, -1 }, new int[] { 34, 4, 3, 3, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0017194730462506414, -0.74376249313354492, 0.13561910390853879, new int[] { 20, 9, 4, 2, -1 }, new int[] { 20, 9, 2, 1, 2 }, new int[] { 22, 10, 2, 1, 2 } ) });
            stage.Trees = nodes.ToArray(); stages.Add(stage);
            #endregion

            #region Stage 3
            stage = new HaarCascadeStage(-2.4261860847473145, 2, -1); nodes = new List<HaarFeatureNode[]>();
            nodes.Add(new[] { new HaarFeatureNode(-0.29845130443573, 0.57684171199798584, -0.56365752220153809, new int[] { 0, 0, 24, 9, -1 }, new int[] { 8, 3, 8, 3, 9 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0848317891359329, -0.48785820603370672, 0.30233600735664368, new int[] { 7, 3, 36, 4, -1 }, new int[] { 16, 3, 18, 4, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0048235268332064152, -0.41680189967155462, 0.54730242490768433, new int[] { 9, 5, 4, 2, -1 }, new int[] { 11, 5, 2, 2, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.024796100333333, -0.40749680995941162, 0.29871928691864008, new int[] { 22, 0, 6, 10, -1 }, new int[] { 22, 0, 3, 10, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0078466311097145081, -0.66262972354888916, 0.30879470705986017, new int[] { 0, 5, 6, 6, -1 }, new int[] { 0, 8, 6, 3, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0881724432110786, -0.196403294801712, 0.17876540124416351, new int[] { 21, 0, 8, 11, -1 }, new int[] { 21, 0, 4, 11, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.00067136192228645086, -0.4565294086933136, 0.47216510772705078, new int[] { 1, 3, 42, 8, -1 }, new int[] { 1, 3, 21, 4, 2 }, new int[] { 22, 7, 21, 4, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-5.8130059187533334E-05, 0.0189487598836422, -0.279009610414505, true, new int[] { 24, 0, 8, 3, -1 }, new int[] { 26, 2, 4, 3, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0070680370554327965, 0.43155920505523682, -0.52287191152572632, true, new int[] { 21, 0, 3, 8, -1 }, new int[] { 19, 2, 3, 4, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0104867396876216, -0.62000381946563721, 0.40068510174751282, new int[] { 35, 3, 2, 8, -1 }, new int[] { 35, 7, 2, 4, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0301965996623039, -0.72579962015151978, 0.19102710485458371, new int[] { 2, 4, 36, 5, -1 }, new int[] { 11, 4, 18, 5, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0022740899585187435, -0.74379247426986694, 0.14359140396118161, new int[] { 12, 0, 21, 1, -1 }, new int[] { 19, 0, 7, 1, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0028281889390200377, -0.70359271764755249, 0.20774589478969571, new int[] { 8, 5, 2, 6, -1 }, new int[] { 8, 8, 2, 3, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(9.4722010544501245E-05, -0.68661361932754517, 0.23000240325927729, new int[] { 24, 9, 11, 2, -1 }, new int[] { 24, 10, 11, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(5.848670843988657E-05, -0.74927699565887451, 0.17420600354671481, new int[] { 2, 7, 2, 4, -1 }, new int[] { 2, 9, 2, 2, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-5.3329051297623664E-05, 0.19545179605484009, -0.64602172374725342, true, new int[] { 42, 4, 2, 2, -1 }, new int[] { 42, 4, 1, 2, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-1.9914070435333997E-05, 0.31910550594329828, -0.50005888938903809, true, new int[] { 3, 4, 2, 2, -1 }, new int[] { 3, 4, 2, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0284833405166864, 0.27206888794898992, -0.17283840477466581, new int[] { 23, 6, 16, 5, -1 }, new int[] { 27, 6, 8, 5, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0070301168598234653, 0.49069970846176147, -0.25846821069717407, true, new int[] { 10, 2, 2, 4, -1 }, new int[] { 9, 3, 2, 2, 2 } ) });
            stage.Trees = nodes.ToArray(); stages.Add(stage);
            #endregion

            #region Stage 4
            stage = new HaarCascadeStage(-1.6515820026397705, 3, -1); nodes = new List<HaarFeatureNode[]>();
            nodes.Add(new[] { new HaarFeatureNode(0.1710568964481354, -0.56416177749633789, 0.5475422739982605, new int[] { 6, 3, 33, 3, -1 }, new int[] { 17, 3, 11, 3, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.1049742996692658, 0.47274130582809448, -0.45322591066360468, new int[] { 31, 1, 9, 9, -1 }, new int[] { 34, 4, 3, 3, 9 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.031381469219923, 0.49009248614311218, -0.35930469632148743, true, new int[] { 9, 0, 6, 3, -1 }, new int[] { 11, 2, 2, 3, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0624266900122166, -0.31271660327911383, 0.3738982081413269, new int[] { 21, 1, 8, 10, -1 }, new int[] { 21, 1, 4, 10, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0547255501151085, -0.43851169943809509, 0.33310478925704962, new int[] { 7, 3, 26, 5, -1 }, new int[] { 20, 3, 13, 5, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0047346241772174835, -0.641412079334259, 0.253116101026535, new int[] { 40, 5, 3, 6, -1 }, new int[] { 40, 8, 3, 3, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0079919751733541489, -0.46805310249328608, 0.24310259521007541, new int[] { 2, 5, 3, 6, -1 }, new int[] { 2, 8, 3, 3, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0162186194211245, -0.3655829131603241, 0.19355100393295291, new int[] { 13, 0, 21, 1, -1 }, new int[] { 20, 0, 7, 1, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0027070839423686266, -0.62368887662887573, 0.1524621993303299, new int[] { 10, 9, 11, 2, -1 }, new int[] { 10, 10, 11, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0145703395828605, 0.254883199930191, -0.101772703230381, true, new int[] { 35, 2, 4, 3, -1 }, new int[] { 36, 3, 2, 3, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0742893293499947, -0.59631901979446411, 0.14141720533370969, new int[] { 9, 0, 26, 10, -1 }, new int[] { 9, 0, 13, 5, 2 }, new int[] { 22, 5, 13, 5, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0174824707210064, 0.0689812228083611, -0.807526171207428, new int[] { 1, 9, 44, 2, -1 }, new int[] { 23, 9, 22, 1, 2 }, new int[] { 1, 10, 22, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.000745959987398237, 0.0899708569049835, -0.75478130578994751, new int[] { 21, 9, 2, 2, -1 }, new int[] { 21, 9, 1, 1, 2 }, new int[] { 22, 10, 1, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.68119657039642334, 0.1251329034566879, -0.59507852792739868, new int[] { 0, 0, 45, 9, -1 }, new int[] { 15, 3, 15, 3, 9 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.00032223601010628045, -0.54766350984573364, 0.14170460402965551, new int[] { 21, 9, 2, 2, -1 }, new int[] { 21, 9, 1, 1, 2 }, new int[] { 22, 10, 1, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0013318139826878905, -0.46108511090278631, 0.0877417027950287, new int[] { 39, 9, 5, 2, -1 }, new int[] { 39, 10, 5, 1, 2 } ) });
            stage.Trees = nodes.ToArray(); stages.Add(stage);
            #endregion

            #region Stage 5
            stage = new HaarCascadeStage(-1.8342440128326416, 4, -1); nodes = new List<HaarFeatureNode[]>();
            nodes.Add(new[] { new HaarFeatureNode(0.0799669772386551, -0.66598808765411377, 0.42352628707885742, new int[] { 4, 3, 32, 3, -1 }, new int[] { 12, 3, 16, 3, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0272646602243185, 0.33973929286003107, -0.50634992122650146, new int[] { 26, 1, 11, 8, -1 }, new int[] { 26, 3, 11, 4, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0288831908255816, -0.49011540412902832, 0.40123671293258673, new int[] { 17, 1, 6, 9, -1 }, new int[] { 20, 1, 3, 9, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0397321991622448, -0.4774664044380188, 0.20590600371360779, new int[] { 27, 3, 11, 8, -1 }, new int[] { 27, 7, 11, 4, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0972145274281502, 0.4514232873916626, -0.469965785741806, new int[] { 5, 1, 9, 9, -1 }, new int[] { 8, 4, 3, 3, 9 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0070403199642896652, -0.50513231754302979, 0.18722230195999151, new int[] { 13, 0, 21, 1, -1 }, new int[] { 20, 0, 7, 1, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0100332498550415, -0.60716050863265991, 0.20498579740524289, new int[] { 9, 3, 11, 8, -1 }, new int[] { 9, 7, 11, 4, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0022186320275068283, 0.27919989824295038, -0.390918493270874, new int[] { 38, 5, 6, 2, -1 }, new int[] { 40, 5, 2, 2, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0728399306535721, -0.0087004872038960457, -4366.7841796875, new int[] { 8, 9, 16, 1, -1 }, new int[] { 16, 9, 8, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0686440467834473, 0.54671740531921387, -0.0971203967928886, new int[] { 18, 0, 15, 10, -1 }, new int[] { 23, 0, 5, 10, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(8.3757557149510831E-05, -0.43773889541625982, 0.20737740397453311, new int[] { 3, 9, 4, 2, -1 }, new int[] { 3, 10, 4, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.001888295984826982, 0.28053081035614008, -0.112383596599102, new int[] { 31, 5, 2, 2, -1 }, new int[] { 31, 5, 1, 2, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0362426303327084, -0.63709640502929688, 0.14787060022354129, new int[] { 12, 0, 20, 6, -1 }, new int[] { 12, 0, 10, 3, 2 }, new int[] { 22, 3, 10, 3, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0333381183445454, 0.47268480062484741, -0.212401494383812, new int[] { 31, 0, 10, 6, -1 }, new int[] { 31, 2, 10, 2, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0025847079232335091, 0.1234423965215683, -0.74099230766296387, new int[] { 7, 10, 4, 1, -1 }, new int[] { 9, 10, 2, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0203724894672632, 0.13778980076313019, -0.19940899312496191, new int[] { 25, 0, 15, 4, -1 }, new int[] { 30, 0, 5, 4, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0036333200987428427, 0.0793613791465759, -0.760002076625824, new int[] { 5, 10, 6, 1, -1 }, new int[] { 7, 10, 2, 1, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0046827611513435841, -0.0661458671092987, 0.17332559823989871, new int[] { 38, 5, 4, 4, -1 }, new int[] { 40, 5, 2, 2, 2 }, new int[] { 38, 7, 2, 2, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0048445351421833038, 0.44801148772239691, -0.15643960237503049, new int[] { 3, 5, 4, 4, -1 }, new int[] { 3, 5, 2, 2, 2 }, new int[] { 5, 7, 2, 2, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.24819609522819519, -0.086152970790863, 0.33757150173187261, new int[] { 15, 2, 18, 9, -1 }, new int[] { 21, 2, 6, 9, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.1942128986120224, -0.14059330523014071, 0.511216402053833, new int[] { 12, 0, 15, 11, -1 }, new int[] { 17, 0, 5, 11, 3 } ) });
            stage.Trees = nodes.ToArray(); stages.Add(stage);
            #endregion

            #region Stage 6
            stage = new HaarCascadeStage(-1.6580430269241333, 5, -1); nodes = new List<HaarFeatureNode[]>();
            nodes.Add(new[] { new HaarFeatureNode(-0.0096888672560453415, 0.38957211375236511, -0.48118248581886292, true, new int[] { 8, 1, 6, 1, -1 }, new int[] { 10, 3, 2, 1, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.29810279607772833, -0.480063408613205, 0.39554169774055481, new int[] { 9, 0, 27, 7, -1 }, new int[] { 18, 0, 9, 7, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0098945433273911476, 0.4206601083278656, -0.34448111057281489, true, new int[] { 10, 2, 3, 4, -1 }, new int[] { 9, 3, 3, 2, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0562895499169827, -0.23237819969654081, 0.420012503862381, new int[] { 18, 3, 9, 8, -1 }, new int[] { 21, 3, 3, 8, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0281865298748016, -0.54988211393356323, 0.19484530389308929, new int[] { 0, 5, 11, 6, -1 }, new int[] { 0, 8, 11, 3, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0471157617866993, 0.16842770576477051, -0.53077638149261475, new int[] { 1, 3, 44, 8, -1 }, new int[] { 23, 3, 22, 4, 2 }, new int[] { 1, 7, 22, 4, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0031187951099127531, 0.1967993974685669, -0.3741619884967804, new int[] { 0, 4, 4, 4, -1 }, new int[] { 2, 4, 2, 4, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0194239094853401, -0.44669228792190552, 0.1685253977775574, new int[] { 24, 3, 11, 8, -1 }, new int[] { 24, 7, 11, 4, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.26180699467659, -0.83780890703201294, 0.0617749504745007, new int[] { 3, 1, 39, 9, -1 }, new int[] { 16, 4, 13, 3, 9 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0048632198013365269, -0.48009449243545532, 0.0667717605829239, new int[] { 24, 7, 11, 4, -1 }, new int[] { 24, 9, 11, 2, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0384115986526012, 0.13380399346351621, -0.58349931240081787, new int[] { 11, 4, 22, 6, -1 }, new int[] { 11, 4, 11, 3, 2 }, new int[] { 22, 7, 11, 3, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0057644587941467762, 0.0822187215089798, -0.81420588493347168, new int[] { 33, 9, 6, 2, -1 }, new int[] { 35, 9, 2, 2, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0277032200247049, 0.47253361344337458, -0.1494240015745163, new int[] { 6, 0, 7, 6, -1 }, new int[] { 6, 2, 7, 2, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.00029970629839226604, -0.35082170367240911, 0.117889903485775, new int[] { 24, 0, 6, 1, -1 }, new int[] { 24, 0, 3, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0066997818648815155, -0.1563594043254852, 0.36560869216918951, new int[] { 4, 1, 10, 3, -1 }, new int[] { 4, 2, 10, 1, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(1.8159940736950375E-05, -0.31400790810585022, 0.12775659561157229, new int[] { 36, 9, 9, 2, -1 }, new int[] { 36, 10, 9, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0023775480221956968, -0.71568191051483154, 0.0758587494492531, new int[] { 7, 9, 4, 2, -1 }, new int[] { 8, 9, 2, 2, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0044308858923614025, -0.57954931259155273, 0.0658802017569542, new int[] { 18, 9, 10, 2, -1 }, new int[] { 23, 9, 5, 1, 2 }, new int[] { 18, 10, 5, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0826033428311348, 0.0700204968452454, -0.66175222396850586, new int[] { 7, 0, 30, 6, -1 }, new int[] { 7, 0, 15, 3, 2 }, new int[] { 22, 3, 15, 3, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.008366631343960762, -0.49013429880142212, 0.0937642827630043, new int[] { 21, 5, 3, 6, -1 }, new int[] { 22, 7, 1, 2, 9 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.004212609026581049, -0.58547890186309814, 0.0777199864387512, new int[] { 16, 9, 10, 2, -1 }, new int[] { 16, 9, 5, 1, 2 }, new int[] { 21, 10, 5, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0014681339962407947, -0.24955469369888311, 0.1152582988142967, new int[] { 24, 9, 11, 2, -1 }, new int[] { 24, 10, 11, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.00572782289236784, -0.119686096906662, 0.42483189702034, new int[] { 5, 2, 7, 3, -1 }, new int[] { 5, 3, 7, 1, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.006577933207154274, 0.0282375905662775, -0.407177597284317, new int[] { 26, 0, 4, 1, -1 }, new int[] { 26, 0, 2, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(1.2635639905056451E-05, -0.3278765082359314, 0.1463759988546372, new int[] { 15, 0, 4, 1, -1 }, new int[] { 17, 0, 2, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0046048699878156185, 0.18424710631370539, -0.23546899855136871, new int[] { 26, 0, 11, 4, -1 }, new int[] { 26, 2, 11, 2, 2 } ) });
            stage.Trees = nodes.ToArray(); stages.Add(stage);
            #endregion

            #region Stage 7
            stage = new HaarCascadeStage(-1.7386059761047363, 6, -1); nodes = new List<HaarFeatureNode[]>();
            nodes.Add(new[] { new HaarFeatureNode(0.0616270788013935, -0.63852781057357788, 0.333147406578064, new int[] { 7, 3, 22, 3, -1 }, new int[] { 18, 3, 11, 3, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0042768982239067554, -0.42443430423736572, 0.43040299415588379, new int[] { 32, 1, 4, 6, -1 }, new int[] { 34, 1, 2, 3, 2 }, new int[] { 32, 4, 2, 3, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0046536661684513092, -0.3571257889270783, 0.34206199645996088, new int[] { 9, 1, 4, 6, -1 }, new int[] { 9, 1, 2, 3, 2 }, new int[] { 11, 4, 2, 3, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0899298489093781, -0.30818319320678711, 0.31036278605461121, new int[] { 17, 0, 12, 11, -1 }, new int[] { 21, 0, 4, 11, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0743535533547401, -0.41107970476150513, 0.27357169985771179, new int[] { 1, 3, 11, 8, -1 }, new int[] { 1, 7, 11, 4, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0018687270348891616, -0.326781690120697, 0.1846697926521301, new int[] { 25, 9, 11, 2, -1 }, new int[] { 25, 10, 11, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0062053278088569641, 0.3107973039150238, -0.2444406002759934, new int[] { 1, 4, 6, 4, -1 }, new int[] { 3, 4, 2, 4, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0163297392427921, 0.249386802315712, -0.38487339019775391, new int[] { 24, 1, 11, 8, -1 }, new int[] { 24, 3, 11, 4, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.11337800323963169, -0.43810528516769409, 0.15818390250205991, new int[] { 4, 0, 32, 7, -1 }, new int[] { 12, 0, 16, 7, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0748228132724762, 0.0775939524173737, -0.6171107292175293, new int[] { 8, 0, 30, 8, -1 }, new int[] { 23, 0, 15, 4, 2 }, new int[] { 8, 4, 15, 4, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0451328605413437, 0.59627789258956909, -0.1065089032053947, new int[] { 19, 2, 6, 9, -1 }, new int[] { 22, 2, 3, 9, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0102611603215337, 0.34028670191764832, -0.0760131329298019, new int[] { 17, 0, 26, 2, -1 }, new int[] { 30, 0, 13, 1, 2 }, new int[] { 17, 1, 13, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.00019562950183171779, -0.32240030169487, 0.15930220484733579, true, new int[] { 20, 0, 1, 2, -1 }, new int[] { 20, 0, 1, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0127499103546143, 0.0342378690838814, -0.8233301043510437, new int[] { 38, 9, 6, 2, -1 }, new int[] { 38, 10, 6, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0010267910547554493, -0.33482649922370911, 0.14868380129337311, new int[] { 1, 9, 8, 2, -1 }, new int[] { 1, 10, 8, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.011899939738214, -0.1110528036952019, 0.29978659749031072, new int[] { 31, 0, 11, 4, -1 }, new int[] { 31, 1, 11, 2, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.00944048073142767, 0.063143752515316, -0.749141275882721, new int[] { 7, 8, 6, 3, -1 }, new int[] { 9, 8, 2, 3, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0044033881276845932, 0.1506906002759934, -0.1213440969586372, new int[] { 36, 3, 4, 4, -1 }, new int[] { 36, 3, 2, 4, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0082504339516162872, 0.0654440671205521, -0.75574231147766113, true, new int[] { 17, 0, 2, 3, -1 }, new int[] { 17, 0, 1, 3, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.011925470083952, 0.1157917976379395, -0.18231560289859769, new int[] { 25, 1, 11, 6, -1 }, new int[] { 25, 3, 11, 2, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0023744169156998396, -0.23897719383239749, 0.19362419843673709, new int[] { 16, 10, 12, 1, -1 }, new int[] { 19, 10, 6, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0189549792557955, -0.0739023834466934, 0.0952069386839867, new int[] { 11, 1, 32, 4, -1 }, new int[] { 27, 1, 16, 2, 2 }, new int[] { 11, 3, 16, 2, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0064718048088252544, 0.18825650215148931, -0.27421408891677862, new int[] { 10, 1, 11, 6, -1 }, new int[] { 10, 3, 11, 2, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0118858003988862, -0.0793891325592995, 0.39397639036178589, true, new int[] { 39, 2, 5, 3, -1 }, new int[] { 38, 3, 5, 1, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0039641708135604858, -0.31416910886764532, 0.157222107052803, new int[] { 10, 7, 11, 4, -1 }, new int[] { 10, 9, 11, 2, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0153126502409577, 0.43467319011688232, -0.0800591632723808, true, new int[] { 39, 2, 5, 3, -1 }, new int[] { 38, 3, 5, 1, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0044087409041821957, -0.69355368614196777, 0.0726607367396355, true, new int[] { 4, 8, 2, 1, -1 }, new int[] { 4, 8, 1, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0268113501369953, -0.0287350993603468, 0.43056601285934448, true, new int[] { 39, 2, 5, 3, -1 }, new int[] { 38, 3, 5, 1, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.012916729785502, -0.0791131779551506, 0.56161957979202271, true, new int[] { 6, 2, 3, 5, -1 }, new int[] { 7, 3, 1, 5, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0028802119195461273, -0.6684604287147522, 0.0777579322457314, new int[] { 35, 9, 4, 2, -1 }, new int[] { 36, 9, 2, 2, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0775494873523712, 0.6936337947845459, -0.0728587135672569, new int[] { 15, 1, 12, 10, -1 }, new int[] { 19, 1, 4, 10, 3 } ) });
            stage.Trees = nodes.ToArray(); stages.Add(stage);
            #endregion

            #region Stage 8
            stage = new HaarCascadeStage(-1.6643459796905518, 7, -1); nodes = new List<HaarFeatureNode[]>();
            nodes.Add(new[] { new HaarFeatureNode(0.11415310204029081, -0.46382120251655579, 0.38176709413528442, new int[] { 5, 3, 32, 3, -1 }, new int[] { 13, 3, 16, 3, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0048969490453600883, -0.1898743063211441, 0.3679777979850769, new int[] { 30, 5, 6, 2, -1 }, new int[] { 32, 5, 2, 2, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.021013330668211, -0.39102751016616821, 0.30523461103439331, new int[] { 17, 2, 6, 5, -1 }, new int[] { 20, 2, 3, 5, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0085326731204986572, 0.40289008617401117, -0.379458099603653, true, new int[] { 35, 2, 4, 3, -1 }, new int[] { 36, 3, 2, 3, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0022233189083635807, -0.58341151475906372, 0.205049604177475, new int[] { 0, 6, 5, 4, -1 }, new int[] { 0, 8, 5, 2, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.00894554890692234, 0.107344001531601, -0.14078269898891449, new int[] { 33, 4, 6, 4, -1 }, new int[] { 35, 4, 2, 4, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-4.4652701035374776E-05, 0.31881740689277649, -0.24204300343990329, new int[] { 12, 5, 2, 2, -1 }, new int[] { 13, 5, 1, 2, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.27766218781471252, 0.31993478536605841, -0.23212060332298279, new int[] { 21, 1, 24, 6, -1 }, new int[] { 29, 3, 8, 2, 9 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0299928896129131, -0.48636630177497858, 0.15733970701694491, new int[] { 8, 3, 10, 8, -1 }, new int[] { 8, 7, 10, 4, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0103846397250891, -0.35761609673500061, 0.10168769955635069, new int[] { 13, 0, 21, 1, -1 }, new int[] { 20, 0, 7, 1, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0099069289863109589, 0.34743508696556091, -0.20619870722293851, true, new int[] { 9, 2, 6, 3, -1 }, new int[] { 8, 3, 6, 1, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0936803817749023, 0.54358488321304321, -0.073790967464447, new int[] { 16, 2, 18, 8, -1 }, new int[] { 22, 2, 6, 8, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(4.6968900278443471E-05, -0.36511829495429993, 0.20056860148906711, new int[] { 3, 9, 1, 2, -1 }, new int[] { 3, 10, 1, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0083182547241449356, -0.52089792490005493, 0.0516868308186531, true, new int[] { 27, 4, 2, 5, -1 }, new int[] { 27, 4, 1, 5, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.11552570015192031, -0.60911101102828979, 0.0922980234026909, new int[] { 2, 0, 36, 10, -1 }, new int[] { 2, 0, 18, 5, 2 }, new int[] { 20, 5, 18, 5, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(4.5758039050269872E-05, -0.2418815940618515, 0.1120527014136314, new int[] { 26, 1, 2, 1, -1 }, new int[] { 26, 1, 1, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0836199671030045, -0.16591419279575351, 0.29946151375770569, new int[] { 15, 2, 12, 9, -1 }, new int[] { 18, 2, 6, 9, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0017055140342563391, 0.066100686788559, -0.1783421933650971, new int[] { 31, 4, 9, 6, -1 }, new int[] { 34, 4, 3, 6, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0502557195723057, 0.50841152667999268, -0.10191909968853, new int[] { 5, 0, 10, 6, -1 }, new int[] { 5, 2, 10, 2, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0144934700801969, 0.33411300182342529, -0.0912953317165375, true, new int[] { 35, 2, 3, 4, -1 }, new int[] { 34, 3, 3, 2, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0066773351281881332, 0.070742093026638, -0.71941351890563965, new int[] { 5, 9, 6, 2, -1 }, new int[] { 7, 9, 2, 2, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0024902720469981432, 0.27122259140014648, -0.28118500113487238, new int[] { 40, 5, 4, 2, -1 }, new int[] { 40, 5, 2, 2, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0059668770991265774, 0.0868900194764137, -0.5510246753692627, new int[] { 19, 0, 3, 3, -1 }, new int[] { 20, 1, 1, 1, 9 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0089923879131674767, -0.1115676984190941, 0.18312740325927729, new int[] { 31, 0, 11, 4, -1 }, new int[] { 31, 1, 11, 2, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0018761169631034136, 0.16583199799060819, -0.29823789000511169, new int[] { 5, 0, 15, 1, -1 }, new int[] { 10, 0, 5, 1, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0044691809453070164, 0.0676259994506836, -0.59995788335800171, new int[] { 17, 8, 12, 2, -1 }, new int[] { 23, 8, 6, 1, 2 }, new int[] { 17, 9, 6, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0495137684047222, -0.1185320988297463, 0.4067130982875824, new int[] { 19, 2, 6, 9, -1 }, new int[] { 22, 2, 3, 9, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0520960614085197, -0.49050968885421747, 0.0444507598876953, new int[] { 32, 1, 6, 10, -1 }, new int[] { 34, 1, 2, 10, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0575406104326248, 0.22163380682468409, -0.22697730362415311, new int[] { 5, 2, 9, 6, -1 }, new int[] { 8, 4, 3, 2, 9 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0120270904153585, -0.78315860033035278, 0.0252257809042931, true, new int[] { 29, 0, 2, 3, -1 }, new int[] { 28, 1, 2, 1, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0043592308647930622, 0.0784457623958588, -0.54399901628494263, true, new int[] { 16, 0, 3, 2, -1 }, new int[] { 17, 1, 1, 2, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0108451396226883, 0.0435322597622871, -0.75301069021224976, new int[] { 34, 8, 6, 3, -1 }, new int[] { 36, 8, 2, 3, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.00022464629728347063, 0.1888168007135391, -0.21684129536151889, new int[] { 2, 5, 2, 1, -1 }, new int[] { 3, 5, 1, 1, 2 } ) });
            stage.Trees = nodes.ToArray(); stages.Add(stage);
            #endregion

            #region Stage 9
            stage = new HaarCascadeStage(-1.5700939893722534, 8, -1); nodes = new List<HaarFeatureNode[]>();
            nodes.Add(new[] { new HaarFeatureNode(0.15167570114135739, -0.31243559718132019, 0.39714258909225458, new int[] { 6, 3, 33, 2, -1 }, new int[] { 17, 3, 11, 2, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0056243538856506348, 0.2844352126121521, -0.46888008713722229, true, new int[] { 35, 2, 4, 3, -1 }, new int[] { 36, 3, 2, 3, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0133634200319648, 0.29847151041030878, -0.28974089026451111, new int[] { 5, 5, 9, 2, -1 }, new int[] { 8, 5, 3, 2, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.11973579972982409, -0.25059941411018372, 0.36980310082435608, new int[] { 17, 1, 12, 10, -1 }, new int[] { 21, 1, 4, 10, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0295380298048258, -0.53302282094955444, 0.19540609419345861, new int[] { 0, 4, 11, 6, -1 }, new int[] { 0, 7, 11, 3, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0022876099683344364, -0.39356181025505071, 0.22455599904060361, new int[] { 29, 9, 11, 2, -1 }, new int[] { 29, 10, 11, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(3.3369789889547974E-05, -0.42540431022644037, 0.124747097492218, new int[] { 17, 1, 2, 1, -1 }, new int[] { 18, 1, 1, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0122035900130868, -0.111175000667572, 0.33035451173782349, new int[] { 31, 0, 11, 4, -1 }, new int[] { 31, 1, 11, 2, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0288315303623676, -0.26190409064292908, 0.26021391153335571, new int[] { 2, 1, 32, 6, -1 }, new int[] { 2, 1, 16, 3, 2 }, new int[] { 18, 4, 16, 3, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0023157240357249975, 0.0526180006563663, -0.61872607469558716, new int[] { 21, 9, 6, 2, -1 }, new int[] { 24, 9, 3, 1, 2 }, new int[] { 21, 10, 3, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0033288369886577129, 0.0794652178883553, -0.61543351411819458, new int[] { 17, 9, 10, 2, -1 }, new int[] { 17, 9, 5, 1, 2 }, new int[] { 22, 10, 5, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0041650598868727684, 0.22358900308609009, -0.28173050284385681, new int[] { 41, 4, 4, 6, -1 }, new int[] { 41, 4, 2, 6, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0555344186723232, 0.53370571136474609, -0.0978473424911499, new int[] { 4, 0, 10, 6, -1 }, new int[] { 4, 2, 10, 2, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0104300398379564, -0.31936469674110413, 0.13222220540046689, new int[] { 13, 0, 21, 1, -1 }, new int[] { 20, 0, 7, 1, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.737310528755188, 0.0856522768735886, -0.56832748651504517, new int[] { 3, 0, 39, 9, -1 }, new int[] { 16, 3, 13, 3, 9 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0211063101887703, 0.010350720025599, -0.43624758720397949, new int[] { 30, 9, 11, 2, -1 }, new int[] { 30, 10, 11, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.001839456963352859, -0.30258610844612122, 0.1825274974107742, new int[] { 5, 9, 11, 2, -1 }, new int[] { 5, 10, 11, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.006262688897550106, -0.70305782556533813, 0.0345668382942677, new int[] { 20, 9, 8, 2, -1 }, new int[] { 24, 9, 4, 1, 2 }, new int[] { 20, 10, 4, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.002587243914604187, 0.1959318071603775, -0.2503960132598877, new int[] { 1, 5, 6, 3, -1 }, new int[] { 3, 5, 2, 3, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.00796518661081791, 0.056051678955555, -0.48542159795761108, new int[] { 29, 0, 6, 3, -1 }, new int[] { 31, 0, 2, 3, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.2649461030960083, -0.74813681840896606, 0.0572923310101032, new int[] { 3, 0, 39, 9, -1 }, new int[] { 16, 3, 13, 3, 9 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0087696090340614319, 0.55027532577514648, -0.0981863886117935, new int[] { 34, 1, 5, 3, -1 }, new int[] { 34, 2, 5, 1, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.00936076883226633, 0.0879649519920349, -0.63283741474151611, new int[] { 10, 0, 6, 3, -1 }, new int[] { 12, 0, 2, 3, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0067315441556274891, -0.1199072003364563, 0.26050290465354919, new int[] { 33, 1, 8, 3, -1 }, new int[] { 33, 2, 8, 1, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0048705069348216057, -0.6705402135848999, 0.0683697164058685, new int[] { 16, 9, 10, 2, -1 }, new int[] { 16, 9, 5, 1, 2 }, new int[] { 21, 10, 5, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0335185006260872, 0.4375419020652771, -0.0559873282909393, new int[] { 19, 5, 9, 6, -1 }, new int[] { 22, 5, 3, 6, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0076086460612714291, -0.25253391265869141, 0.19854959845542911, new int[] { 16, 9, 12, 2, -1 }, new int[] { 20, 9, 4, 2, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0183347892016172, 0.0830836072564125, -0.49109730124473572, new int[] { 24, 10, 20, 1, -1 }, new int[] { 24, 10, 10, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0027305909898132086, -0.48166638612747192, 0.0870301127433777, true, new int[] { 18, 0, 2, 1, -1 }, new int[] { 18, 0, 1, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0253080893307924, -0.51370352506637573, 0.0317759402096272, new int[] { 24, 10, 20, 1, -1 }, new int[] { 24, 10, 10, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0067148888483643532, -0.46419641375541693, 0.0869181528687477, new int[] { 0, 0, 1, 8, -1 }, new int[] { 0, 4, 1, 4, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0013796479906886816, 0.11364360153675079, -0.1099784001708031, new int[] { 24, 10, 20, 1, -1 }, new int[] { 24, 10, 10, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.017988620325923, -0.56473308801651, 0.0848380699753761, new int[] { 1, 10, 20, 1, -1 }, new int[] { 11, 10, 10, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.00012048670032527298, -0.33594891428947449, 0.1181958019733429, new int[] { 42, 7, 3, 4, -1 }, new int[] { 42, 9, 3, 2, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.007399712223559618, -0.71109187602996826, 0.050271350890398, new int[] { 6, 9, 6, 2, -1 }, new int[] { 8, 9, 2, 2, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0044395271688699722, 0.24038110673427579, -0.0848185420036316, new int[] { 33, 1, 6, 3, -1 }, new int[] { 33, 2, 6, 1, 3 } ) });
            stage.Trees = nodes.ToArray(); stages.Add(stage);
            #endregion

            #region Stage 10
            stage = new HaarCascadeStage(-1.5616159439086914, 9, -1); nodes = new List<HaarFeatureNode[]>();
            nodes.Add(new[] { new HaarFeatureNode(0.006783737801015377, -0.2447407990694046, 0.52373462915420532, true, new int[] { 12, 4, 3, 2, -1 }, new int[] { 13, 5, 1, 2, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0263042896986008, 0.23381529748439789, -0.423664391040802, new int[] { 26, 1, 11, 8, -1 }, new int[] { 26, 3, 11, 4, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0705524832010269, -0.48068380355834961, 0.21674250066280371, new int[] { 3, 4, 30, 3, -1 }, new int[] { 18, 4, 15, 3, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.1158863976597786, -0.21499669551849371, 0.26753580570220947, new int[] { 17, 0, 12, 9, -1 }, new int[] { 21, 0, 4, 9, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0100489500910044, -0.20594270527362821, 0.4048427939414978, new int[] { 2, 0, 9, 4, -1 }, new int[] { 2, 1, 9, 2, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0146281700581312, 0.0451952703297138, -0.4338223934173584, new int[] { 19, 0, 12, 1, -1 }, new int[] { 22, 0, 6, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.1069151982665062, -0.40005341172218323, 0.15653589367866519, new int[] { 7, 0, 28, 5, -1 }, new int[] { 14, 0, 14, 5, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0215446706861258, -0.38369441032409668, 0.1253671050071716, new int[] { 26, 5, 11, 6, -1 }, new int[] { 26, 8, 11, 3, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0050607468001544476, -0.13730029761791229, 0.53118318319320679, new int[] { 4, 5, 4, 2, -1 }, new int[] { 5, 5, 2, 2, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0049039809964597225, -0.69460391998291016, 0.0771185681223869, new int[] { 40, 7, 5, 4, -1 }, new int[] { 40, 9, 5, 2, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0555920600891113, 0.0849511027336121, -0.6161080002784729, new int[] { 5, 5, 34, 6, -1 }, new int[] { 5, 5, 17, 3, 2 }, new int[] { 22, 8, 17, 3, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0539596788585186, -0.378260999917984, 0.033103808760643, new int[] { 7, 2, 38, 3, -1 }, new int[] { 7, 2, 19, 3, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(3.6401430406840518E-05, -0.36711519956588751, 0.1344677954912186, new int[] { 3, 8, 1, 2, -1 }, new int[] { 3, 9, 1, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0055411658249795437, -0.5740044116973877, 0.0742920190095901, true, new int[] { 31, 7, 2, 2, -1 }, new int[] { 31, 7, 1, 2, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.7908669114112854, 0.0774227529764175, -0.63653308153152466, new int[] { 0, 0, 45, 9, -1 }, new int[] { 15, 3, 15, 3, 9 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0044924449175596237, 0.0685045272111893, -0.53273099660873413, new int[] { 35, 9, 6, 2, -1 }, new int[] { 37, 9, 2, 2, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0068721971474587917, -0.65151798725128174, 0.0649006888270378, new int[] { 4, 9, 6, 2, -1 }, new int[] { 6, 9, 2, 2, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0464545413851738, -0.1123898029327393, 0.20744140446186071, new int[] { 19, 5, 9, 6, -1 }, new int[] { 22, 5, 3, 6, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0060355630703270435, -0.0887570977210999, 0.5474855899810791, new int[] { 7, 2, 3, 3, -1 }, new int[] { 7, 3, 3, 1, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.00039944230229593813, 0.0866240411996841, -0.4693656861782074, new int[] { 22, 9, 2, 2, -1 }, new int[] { 23, 9, 1, 1, 2 }, new int[] { 22, 10, 1, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0075040599331259727, -0.0921164527535439, 0.53663599491119385, new int[] { 5, 3, 8, 2, -1 }, new int[] { 5, 4, 8, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.015840120613575, 0.38116949796676641, -0.0695484727621078, new int[] { 20, 2, 8, 9, -1 }, new int[] { 22, 2, 4, 9, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0057859481312334538, 0.0808151513338089, -0.55126720666885376, new int[] { 3, 9, 8, 2, -1 }, new int[] { 5, 9, 4, 2, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0068534379824995995, 0.20171649754047391, -0.29816129803657532, new int[] { 32, 3, 6, 7, -1 }, new int[] { 34, 3, 2, 7, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-3.21466286550276E-05, 0.16275359690189359, -0.25661829113960272, new int[] { 5, 0, 8, 2, -1 }, new int[] { 9, 0, 4, 2, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0483935698866844, 0.0688307136297226, -0.57602387666702271, new int[] { 12, 0, 22, 6, -1 }, new int[] { 23, 0, 11, 3, 2 }, new int[] { 12, 3, 11, 3, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0459545888006687, 0.0570243299007416, -0.65287989377975464, new int[] { 14, 1, 16, 6, -1 }, new int[] { 14, 1, 8, 3, 2 }, new int[] { 22, 4, 8, 3, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0011721630580723286, 0.10443740338087081, -0.23838600516319281, new int[] { 30, 0, 6, 4, -1 }, new int[] { 32, 0, 2, 4, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0040837051346898079, -0.0812310427427292, 0.50901311635971069, new int[] { 4, 4, 4, 2, -1 }, new int[] { 4, 4, 2, 1, 2 }, new int[] { 6, 5, 2, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0164863802492619, -0.55164510011672974, 0.0650377720594406, new int[] { 30, 0, 6, 4, -1 }, new int[] { 32, 0, 2, 4, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0158996805548668, -0.60929298400878906, 0.0601791404187679, new int[] { 9, 0, 6, 4, -1 }, new int[] { 11, 0, 2, 4, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.00037392228841781616, -0.47092041373252869, 0.0943275690078735, new int[] { 22, 9, 2, 2, -1 }, new int[] { 23, 9, 1, 1, 2 }, new int[] { 22, 10, 1, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0451714508235455, -0.157231405377388, 0.25750550627708441, new int[] { 17, 5, 9, 6, -1 }, new int[] { 20, 5, 3, 6, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0039194729179143906, -0.1199349015951157, 0.41458979249000549, new int[] { 30, 5, 4, 2, -1 }, new int[] { 31, 5, 2, 2, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0048551987856626511, 0.0840639695525169, -0.51544702053070068, true, new int[] { 2, 1, 2, 2, -1 }, new int[] { 2, 1, 2, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0497271716594696, -0.0806181132793427, 0.28510481119155878, new int[] { 19, 7, 12, 4, -1 }, new int[] { 23, 7, 4, 4, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0259798001497984, 0.20879699289798739, -0.19923439621925351, new int[] { 7, 2, 10, 6, -1 }, new int[] { 7, 4, 10, 2, 3 } ) });
            stage.Trees = nodes.ToArray(); stages.Add(stage);
            #endregion

            #region Stage 11
            stage = new HaarCascadeStage(-1.4751789569854736, 10, -1); nodes = new List<HaarFeatureNode[]>();
            nodes.Add(new[] { new HaarFeatureNode(0.003688188036903739, -0.2008984982967377, 0.58759230375289917, new int[] { 11, 5, 3, 2, -1 }, new int[] { 12, 5, 1, 2, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.12514260411262509, -0.33750560879707342, 0.30424299836158752, new int[] { 8, 3, 30, 2, -1 }, new int[] { 18, 3, 10, 2, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0107610300183296, -0.17004770040512091, 0.41313949227333069, new int[] { 6, 0, 6, 4, -1 }, new int[] { 6, 1, 6, 2, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0579194091260433, 0.11780419945716861, -0.58375751972198486, new int[] { 7, 3, 32, 8, -1 }, new int[] { 23, 3, 16, 4, 2 }, new int[] { 7, 7, 16, 4, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0142780495807529, -0.52599787712097168, 0.13024589419364929, new int[] { 7, 3, 3, 8, -1 }, new int[] { 7, 7, 3, 4, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0927703380584717, -0.28803780674934393, 0.20918029546737671, new int[] { 17, 0, 12, 11, -1 }, new int[] { 21, 0, 4, 11, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0012687300331890583, -0.68545269966125488, 0.0679697170853615, new int[] { 0, 9, 3, 2, -1 }, new int[] { 0, 10, 3, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0041586877778172493, 0.1577699035406113, -0.37061429023742681, new int[] { 31, 5, 9, 6, -1 }, new int[] { 34, 5, 3, 6, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.002648673951625824, 0.141157403588295, -0.38789930939674377, true, new int[] { 6, 1, 2, 6, -1 }, new int[] { 4, 3, 2, 2, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(3.3513078960822895E-05, -0.1704705953598023, 0.0914910733699799, new int[] { 27, 1, 2, 1, -1 }, new int[] { 27, 1, 1, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(4.181400072411634E-05, -0.3362986147403717, 0.1561553031206131, new int[] { 16, 0, 8, 1, -1 }, new int[] { 18, 0, 4, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0105799995362759, 0.51775962114334106, -0.1234643012285233, new int[] { 33, 2, 6, 3, -1 }, new int[] { 33, 3, 6, 1, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0096945222467184067, -0.0931728109717369, 0.54562288522720337, new int[] { 6, 2, 6, 3, -1 }, new int[] { 6, 3, 6, 1, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0251239091157913, 0.0292009394615889, -0.39561650156974792, new int[] { 31, 5, 9, 6, -1 }, new int[] { 34, 5, 3, 6, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-1.900989082059823E-05, 0.1341307014226914, -0.35932931303977972, new int[] { 5, 5, 9, 6, -1 }, new int[] { 8, 5, 3, 6, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0011085460428148508, 0.07044717669487, -0.50175982713699341, new int[] { 21, 9, 4, 2, -1 }, new int[] { 23, 9, 2, 1, 2 }, new int[] { 21, 10, 2, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0846463814377785, -0.14077399671077731, 0.29327180981636047, new int[] { 15, 5, 12, 6, -1 }, new int[] { 19, 5, 4, 6, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.046889279037714, 0.54173952341079712, -0.0728389322757721, new int[] { 20, 0, 6, 11, -1 }, new int[] { 20, 0, 3, 11, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0199442394077778, -0.49865978956222529, 0.095483623445034, new int[] { 1, 7, 32, 2, -1 }, new int[] { 9, 7, 16, 2, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0023346049711108208, -0.34936821460723883, 0.0865515023469925, new int[] { 24, 7, 11, 4, -1 }, new int[] { 24, 9, 11, 2, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.01252446975559, 0.42317241430282593, -0.10624880343675611, new int[] { 6, 1, 7, 4, -1 }, new int[] { 6, 2, 7, 2, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0074971290305256844, -0.0771219208836555, 0.33112499117851257, new int[] { 34, 0, 5, 3, -1 }, new int[] { 34, 1, 5, 1, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0043038600124418736, 0.44627100229263311, -0.0974933505058289, new int[] { 6, 0, 5, 3, -1 }, new int[] { 6, 1, 5, 1, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0024376739747822285, -0.63246351480484009, 0.072243332862854, new int[] { 35, 9, 4, 2, -1 }, new int[] { 36, 9, 2, 2, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0040068682283163071, 0.0745110064744949, -0.52885991334915161, true, new int[] { 16, 1, 2, 2, -1 }, new int[] { 16, 1, 1, 2, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.16935829818248749, 0.0192001909017563, -0.9361991286277771, new int[] { 7, 0, 34, 8, -1 }, new int[] { 24, 0, 17, 4, 2 }, new int[] { 7, 4, 17, 4, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0051640910096466541, -0.45252829790115362, 0.0837530866265297, true, new int[] { 17, 0, 2, 3, -1 }, new int[] { 17, 0, 1, 3, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0021301470696926117, 0.0590294115245342, -0.59486192464828491, new int[] { 35, 9, 4, 2, -1 }, new int[] { 36, 9, 2, 2, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.00104918098077178, 0.14820049703121191, -0.2572931051254273, new int[] { 8, 0, 9, 2, -1 }, new int[] { 11, 0, 3, 2, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0065077878534793854, -0.10978510230779651, 0.4835182130336762, new int[] { 34, 6, 4, 3, -1 }, new int[] { 34, 7, 4, 1, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0010791060049086809, 0.085893951356411, -0.4989733099937439, new int[] { 20, 9, 4, 2, -1 }, new int[] { 20, 9, 2, 1, 2 }, new int[] { 22, 10, 2, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0113274296745658, -0.88535779714584351, 0.0125310197472572, new int[] { 34, 9, 6, 2, -1 }, new int[] { 36, 9, 2, 2, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0790901929140091, 0.53530997037887573, -0.0705346763134003, new int[] { 18, 2, 8, 9, -1 }, new int[] { 22, 2, 4, 9, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0893929898738861, -0.0239771790802479, 0.54723167419433594, new int[] { 21, 5, 12, 6, -1 }, new int[] { 25, 5, 4, 6, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0116421598941088, 0.24973329901695249, -0.14847369492053991, new int[] { 14, 7, 8, 4, -1 }, new int[] { 16, 7, 4, 4, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0781690627336502, 0.04763562977314, -0.51396459341049194, true, new int[] { 25, 1, 6, 4, -1 }, new int[] { 25, 1, 3, 4, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0052542597986757755, -0.48597300052642822, 0.0724953785538673, true, new int[] { 15, 7, 2, 2, -1 }, new int[] { 15, 7, 2, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0583055093884468, 0.0162678994238377, -0.58864599466323853, new int[] { 24, 7, 11, 4, -1 }, new int[] { 24, 9, 11, 2, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0058591919951140881, -0.31926271319389338, 0.13474270701408389, new int[] { 10, 7, 11, 4, -1 }, new int[] { 10, 9, 11, 2, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0029373338911682367, 0.42839759588241583, -0.092287540435791, new int[] { 32, 5, 3, 2, -1 }, new int[] { 33, 5, 1, 2, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-3.7391098885564134E-05, 0.20448459684848791, -0.18515400588512421, new int[] { 15, 9, 2, 2, -1 }, new int[] { 15, 9, 1, 1, 2 }, new int[] { 16, 10, 1, 1, 2 } ) });
            stage.Trees = nodes.ToArray(); stages.Add(stage);
            #endregion

            #region Stage 12
            stage = new HaarCascadeStage(-1.5896049737930298, 11, -1); nodes = new List<HaarFeatureNode[]>();
            nodes.Add(new[] { new HaarFeatureNode(-0.0061791189946234226, 0.2858026921749115, -0.37005850672721857, true, new int[] { 11, 2, 3, 4, -1 }, new int[] { 12, 3, 1, 4, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0418217703700066, -0.53575879335403442, 0.16827170550823209, new int[] { 21, 0, 12, 5, -1 }, new int[] { 21, 0, 6, 5, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0057136882096529007, -0.3200174868106842, 0.26822981238365168, new int[] { 6, 4, 3, 4, -1 }, new int[] { 6, 6, 3, 2, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0028650460299104452, -0.4246250987052918, 0.1382745951414108, new int[] { 38, 7, 7, 4, -1 }, new int[] { 38, 9, 7, 2, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0029460960067808628, -0.39784219861030579, 0.20654679834842679, true, new int[] { 21, 4, 3, 4, -1 }, new int[] { 21, 4, 3, 2, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0046483702026307583, -0.19075180590152741, 0.2478605061769486, new int[] { 35, 0, 7, 4, -1 }, new int[] { 35, 1, 7, 2, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0023228039499372244, -0.52134007215499878, 0.1056229025125504, new int[] { 0, 7, 6, 4, -1 }, new int[] { 0, 9, 6, 2, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0074393101967871189, 0.16785180568695071, -0.215616300702095, new int[] { 33, 3, 6, 8, -1 }, new int[] { 35, 3, 2, 8, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.00028299659607000649, -0.38065499067306519, 0.14934809505939481, new int[] { 15, 0, 4, 1, -1 }, new int[] { 17, 0, 2, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0132823698222637, 0.0860496163368225, -0.23779979348182681, new int[] { 30, 2, 12, 9, -1 }, new int[] { 34, 2, 4, 9, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0114170601591468, 0.40117940306663508, -0.13484360277652741, true, new int[] { 5, 2, 3, 3, -1 }, new int[] { 6, 3, 1, 3, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.14769020676612851, -0.4884426891803742, 0.0159332603216171, new int[] { 30, 3, 12, 8, -1 }, new int[] { 34, 3, 4, 8, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.00032284119515679777, 0.1182610020041466, -0.38623189926147461, new int[] { 3, 3, 12, 8, -1 }, new int[] { 7, 3, 4, 8, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-3.6730729334522039E-05, 0.1051127016544342, -0.12332110106945041, new int[] { 24, 8, 2, 2, -1 }, new int[] { 25, 8, 1, 1, 2 }, new int[] { 24, 9, 1, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.00043103349162265658, 0.0800743401050568, -0.5640835165977478, new int[] { 19, 8, 2, 2, -1 }, new int[] { 19, 8, 1, 1, 2 }, new int[] { 20, 9, 1, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.00087611482013016939, -0.4112376868724823, 0.0354818105697632, new int[] { 24, 8, 2, 2, -1 }, new int[] { 25, 8, 1, 1, 2 }, new int[] { 24, 9, 1, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.00036012110649608076, -0.39288720488548279, 0.10729379951953889, new int[] { 19, 8, 2, 2, -1 }, new int[] { 19, 8, 1, 1, 2 }, new int[] { 20, 9, 1, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0113291796296835, -0.077669121325016, 0.30630418658256531, new int[] { 20, 0, 22, 2, -1 }, new int[] { 31, 0, 11, 1, 2 }, new int[] { 20, 1, 11, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0085942242294549942, 0.40262201428413391, -0.1134836971759796, new int[] { 3, 0, 22, 2, -1 }, new int[] { 3, 0, 11, 1, 2 }, new int[] { 14, 1, 11, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.011088109575212, 0.13112230598926539, -0.16582110524177551, new int[] { 29, 0, 3, 9, -1 }, new int[] { 30, 3, 1, 3, 9 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0023962128907442093, 0.18446379899978641, -0.21245540678501129, new int[] { 12, 4, 6, 3, -1 }, new int[] { 14, 4, 2, 3, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.00144913699477911, 0.1329172998666763, -0.34224191308021551, true, new int[] { 41, 0, 4, 2, -1 }, new int[] { 42, 1, 2, 2, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.002347113098949194, -0.59373968839645386, 0.0526771508157253, new int[] { 6, 9, 4, 2, -1 }, new int[] { 7, 9, 2, 2, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0330210588872433, 0.2065508961677551, -0.1164072006940842, new int[] { 21, 5, 12, 4, -1 }, new int[] { 25, 5, 4, 4, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0175966992974281, 0.1161578968167305, -0.28771498799324041, new int[] { 10, 0, 11, 9, -1 }, new int[] { 10, 3, 11, 3, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0906155630946159, 0.0494296513497829, -0.59598392248153687, new int[] { 1, 4, 44, 6, -1 }, new int[] { 23, 4, 22, 3, 2 }, new int[] { 1, 7, 22, 3, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.419732391834259, -0.91762787103652954, 0.0291445106267929, new int[] { 1, 1, 42, 9, -1 }, new int[] { 15, 4, 14, 3, 9 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0045256591401994228, 0.30929449200630188, -0.1158910989761353, true, new int[] { 39, 4, 3, 2, -1 }, new int[] { 40, 5, 1, 2, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-3.1792598747415468E-05, 0.123007096350193, -0.2696146965026856, new int[] { 1, 3, 2, 6, -1 }, new int[] { 2, 3, 1, 6, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0093048512935638428, -0.16311720013618469, 0.45435959100723272, true, new int[] { 33, 3, 3, 3, -1 }, new int[] { 32, 4, 3, 1, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.1818266957998276, -0.0654629319906235, 0.52403932809829712, new int[] { 16, 0, 12, 11, -1 }, new int[] { 22, 0, 6, 11, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0076404958963394165, -0.28455978631973272, 0.0992625430226326, new int[] { 24, 6, 11, 4, -1 }, new int[] { 24, 8, 11, 2, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0058155450969934464, -0.18076479434967041, 0.19177889823913569, new int[] { 15, 9, 12, 1, -1 }, new int[] { 19, 9, 4, 1, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0204726494848728, -0.0425470508635044, 0.49899381399154658, true, new int[] { 33, 3, 3, 3, -1 }, new int[] { 32, 4, 3, 1, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0099484594538807869, 0.458646297454834, -0.0820730701088905, true, new int[] { 12, 3, 3, 3, -1 }, new int[] { 13, 4, 1, 3, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0056835189461708069, 0.0704604163765907, -0.49191218614578253, new int[] { 30, 0, 6, 2, -1 }, new int[] { 32, 0, 2, 2, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.00068594329059123993, -0.257220596075058, 0.1333848983049393, new int[] { 10, 9, 4, 2, -1 }, new int[] { 10, 10, 4, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0085325147956609726, 0.0542962700128555, -0.48597770929336548, true, new int[] { 42, 0, 2, 3, -1 }, new int[] { 42, 0, 1, 3, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0029188990592956543, -0.36844459176063538, 0.0876302868127823, true, new int[] { 3, 0, 3, 2, -1 }, new int[] { 3, 0, 3, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0051809879951179028, 0.26872760057449341, -0.13063269853591919, new int[] { 37, 2, 3, 4, -1 }, new int[] { 37, 3, 3, 2, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0093669425696134567, 0.37982439994812012, -0.0849703624844551, new int[] { 5, 0, 9, 4, -1 }, new int[] { 5, 1, 9, 2, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.00214936095289886, 0.0673641711473465, -0.38138151168823242, new int[] { 43, 9, 2, 2, -1 }, new int[] { 43, 10, 2, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0079133054241538048, 0.0611798018217087, -0.47124278545379639, new int[] { 14, 0, 14, 2, -1 }, new int[] { 14, 0, 7, 1, 2 }, new int[] { 21, 1, 7, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0033651650883257389, -0.194069504737854, 0.169578492641449, new int[] { 34, 6, 4, 2, -1 }, new int[] { 34, 7, 4, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(5.975261956336908E-05, -0.3129621148109436, 0.0982444435358047, new int[] { 18, 0, 8, 1, -1 }, new int[] { 20, 0, 4, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0048905829899013042, 0.24011640250682831, -0.0405179113149643, new int[] { 23, 6, 4, 4, -1 }, new int[] { 23, 6, 2, 4, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0166922602802515, -0.58297210931777954, 0.0518608801066875, new int[] { 0, 9, 44, 2, -1 }, new int[] { 0, 9, 22, 1, 2 }, new int[] { 22, 10, 22, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.2694517970085144, 0.0212223697453737, -0.506509006023407, new int[] { 10, 0, 32, 5, -1 }, new int[] { 10, 0, 16, 5, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.25985699892044067, 0.0430213287472725, -0.69706851243972778, new int[] { 3, 0, 32, 5, -1 }, new int[] { 19, 0, 16, 5, 2 } ) });
            stage.Trees = nodes.ToArray(); stages.Add(stage);
            #endregion

            #region Stage 13
            stage = new HaarCascadeStage(-1.5319960117340088, 12, -1); nodes = new List<HaarFeatureNode[]>();
            nodes.Add(new[] { new HaarFeatureNode(0.0096479244530200958, -0.21499650180339811, 0.45064011216163641, true, new int[] { 12, 4, 3, 3, -1 }, new int[] { 13, 5, 1, 3, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.1170708984136581, -0.4592719972133637, 0.14997510612010961, new int[] { 19, 0, 18, 7, -1 }, new int[] { 19, 0, 9, 7, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0072843180969357491, 0.2055986970663071, -0.3498862087726593, true, new int[] { 10, 2, 3, 4, -1 }, new int[] { 9, 3, 3, 2, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(4.3017291318392381E-05, -0.29128479957580572, 0.1447937935590744, new int[] { 24, 2, 2, 1, -1 }, new int[] { 24, 2, 1, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0163135603070259, 0.360995888710022, -0.14882080256938929, new int[] { 5, 2, 10, 4, -1 }, new int[] { 5, 3, 10, 2, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.38464391231536871, 0.0471165515482426, -0.54356420040130615, new int[] { 12, 0, 26, 9, -1 }, new int[] { 12, 0, 13, 9, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(4.4735490519087762E-05, -0.4715361893177033, 0.1013057008385658, new int[] { 1, 9, 6, 2, -1 }, new int[] { 1, 10, 6, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0028128800913691521, 0.0251902397722006, -0.38858410716056818, new int[] { 24, 2, 2, 1, -1 }, new int[] { 24, 2, 1, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0656641125679016, -0.19981299340724951, 0.27820420265197748, new int[] { 18, 3, 9, 8, -1 }, new int[] { 21, 3, 3, 8, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0366914011538029, -0.32141581177711492, 0.0832958593964577, new int[] { 26, 5, 11, 6, -1 }, new int[] { 26, 8, 11, 3, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0199371706694365, 0.0962692573666573, -0.48872131109237671, new int[] { 11, 5, 22, 4, -1 }, new int[] { 11, 5, 11, 2, 2 }, new int[] { 22, 7, 11, 2, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0481815114617348, -0.436909407377243, 0.0408011004328728, new int[] { 14, 0, 20, 6, -1 }, new int[] { 24, 0, 10, 3, 2 }, new int[] { 14, 3, 10, 3, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0064909900538623333, 0.15237170457839971, -0.28793171048164368, new int[] { 7, 0, 12, 3, -1 }, new int[] { 11, 0, 4, 3, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0021715220063924789, -0.45620518922805792, 0.0908001735806465, new int[] { 41, 7, 4, 4, -1 }, new int[] { 41, 8, 4, 2, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0190357100218534, 0.16175259649753571, -0.24115300178527829, new int[] { 1, 3, 6, 6, -1 }, new int[] { 3, 5, 2, 2, 9 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0171191804111004, -0.51326441764831543, 0.0424724705517292, new int[] { 28, 0, 6, 4, -1 }, new int[] { 30, 0, 2, 4, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0182200502604246, -0.70324420928955078, 0.0449626408517361, new int[] { 10, 0, 6, 4, -1 }, new int[] { 12, 0, 2, 4, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.00892651081085205, 0.43140518665313721, -0.19158810377120969, true, new int[] { 40, 2, 3, 3, -1 }, new int[] { 39, 3, 3, 1, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0835192427039146, -0.61536192893981934, 0.074886828660965, new int[] { 10, 1, 11, 8, -1 }, new int[] { 10, 3, 11, 4, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0003607225080486387, 0.0579051412642002, -0.41235160827636719, new int[] { 22, 8, 2, 2, -1 }, new int[] { 23, 8, 1, 1, 2 }, new int[] { 22, 9, 1, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0049997381865978241, -0.0698446407914162, 0.56807458400726318, new int[] { 7, 3, 3, 3, -1 }, new int[] { 7, 4, 3, 1, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0846046805381775, 0.5883864164352417, -0.064438559114933, new int[] { 19, 0, 8, 11, -1 }, new int[] { 19, 0, 4, 11, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0257730204612017, -0.74485701322555542, 0.058126550167799, new int[] { 0, 10, 22, 1, -1 }, new int[] { 11, 10, 11, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0869977995753288, 0.0083158798515796661, -0.5005766749382019, new int[] { 12, 0, 24, 6, -1 }, new int[] { 24, 0, 12, 3, 2 }, new int[] { 12, 3, 12, 3, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0049193361774086952, -0.50268518924713135, 0.0622738115489483, true, new int[] { 19, 5, 4, 2, -1 }, new int[] { 19, 5, 4, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0079372245818376541, -0.1065687015652657, 0.49397408962249761, true, new int[] { 40, 3, 3, 3, -1 }, new int[] { 39, 4, 3, 1, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0023460648953914642, 0.0781724527478218, -0.4353787899017334, true, new int[] { 2, 4, 6, 1, -1 }, new int[] { 2, 4, 3, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0241736993193626, 0.14930419623851779, -0.18787060678005221, new int[] { 35, 3, 10, 6, -1 }, new int[] { 35, 3, 5, 6, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0050533721223473549, -0.10777329653501511, 0.33679130673408508, new int[] { 5, 2, 6, 3, -1 }, new int[] { 5, 3, 6, 1, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.17847840487957, 0.325364887714386, -0.0435284599661827, new int[] { 18, 2, 18, 9, -1 }, new int[] { 24, 2, 6, 9, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0092971222475171089, -0.54683762788772583, 0.0642068088054657, new int[] { 0, 0, 1, 8, -1 }, new int[] { 0, 4, 1, 4, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.00453316792845726, -0.274022787809372, 0.0696792080998421, true, new int[] { 27, 0, 2, 2, -1 }, new int[] { 27, 0, 2, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0044196969829499722, -0.26736640930175781, 0.12777979671955109, new int[] { 7, 1, 26, 4, -1 }, new int[] { 7, 1, 13, 2, 2 }, new int[] { 20, 3, 13, 2, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.02425641939044, -0.73339939117431641, 0.0348337702453136, new int[] { 34, 8, 9, 3, -1 }, new int[] { 37, 8, 3, 3, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0120942499488592, 0.0672335624694824, -0.44198140501976008, new int[] { 2, 8, 9, 3, -1 }, new int[] { 5, 8, 3, 3, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.00031668329029344022, -0.34792518615722662, 0.0869572535157204, new int[] { 22, 8, 2, 2, -1 }, new int[] { 23, 8, 1, 1, 2 }, new int[] { 22, 9, 1, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0066463160328567028, -0.0748405605554581, 0.4297528862953186, true, new int[] { 5, 3, 3, 3, -1 }, new int[] { 6, 4, 1, 3, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0087216906249523163, 0.0659606382250786, -0.1169529035687447, new int[] { 35, 3, 10, 3, -1 }, new int[] { 35, 3, 5, 3, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(3.8271831726888195E-05, -0.26323419809341431, 0.12117200344800951, new int[] { 19, 2, 2, 1, -1 }, new int[] { 20, 2, 1, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0279251895844936, 0.11978749930858611, -0.1062619984149933, new int[] { 21, 3, 12, 8, -1 }, new int[] { 24, 3, 6, 8, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0036273279692977667, 0.12563459575176239, -0.26336249709129328, new int[] { 0, 3, 10, 3, -1 }, new int[] { 5, 3, 5, 3, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0118683502078056, 0.27150759100914, -0.0586201399564743, new int[] { 19, 6, 9, 5, -1 }, new int[] { 22, 6, 3, 5, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0441535599529743, -0.11503530293703081, 0.31426700949668879, new int[] { 19, 0, 6, 11, -1 }, new int[] { 22, 0, 3, 11, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0240563601255417, 0.0755757391452789, -0.4231755137443543, new int[] { 21, 0, 3, 9, -1 }, new int[] { 22, 3, 1, 3, 9 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.00069733301643282175, -0.0975871905684471, 0.328766405582428, new int[] { 12, 5, 2, 2, -1 }, new int[] { 12, 5, 1, 1, 2 }, new int[] { 13, 6, 1, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0064465990290045738, -0.71510308980941772, 0.0252250991761684, new int[] { 20, 9, 8, 2, -1 }, new int[] { 24, 9, 4, 1, 2 }, new int[] { 20, 10, 4, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.00818709097802639, -0.766850471496582, 0.0325768813490868, true, new int[] { 13, 7, 2, 2, -1 }, new int[] { 13, 7, 2, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.002769421087577939, 0.2407584935426712, -0.14446850121021271, true, new int[] { 31, 5, 3, 3, -1 }, new int[] { 30, 6, 3, 1, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0059827328659594059, -0.0796374008059502, 0.336481899023056, new int[] { 8, 1, 3, 3, -1 }, new int[] { 8, 2, 3, 1, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0075759701430797577, -0.0772878602147102, 0.3606812059879303, new int[] { 34, 1, 4, 3, -1 }, new int[] { 34, 2, 4, 1, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.003734994912520051, 0.3505760133266449, -0.10241500288248059, new int[] { 7, 1, 5, 3, -1 }, new int[] { 7, 2, 5, 1, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0032173299696296453, 0.0646449029445648, -0.50682359933853149, true, new int[] { 31, 1, 1, 2, -1 }, new int[] { 31, 1, 1, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0005229968810454011, 0.0554051995277405, -0.49950990080833441, new int[] { 21, 8, 2, 2, -1 }, new int[] { 21, 8, 1, 1, 2 }, new int[] { 22, 9, 1, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.00048098989645950496, -0.24837599694728851, 0.0749513134360313, new int[] { 26, 9, 10, 2, -1 }, new int[] { 26, 10, 10, 1, 2 } ) });
            stage.Trees = nodes.ToArray(); stages.Add(stage);
            #endregion

            #region Stage 14
            stage = new HaarCascadeStage(-1.5442479848861694, 13, -1); nodes = new List<HaarFeatureNode[]>();
            nodes.Add(new[] { new HaarFeatureNode(-0.0325478985905647, 0.257082611322403, -0.3294408917427063, true, new int[] { 9, 0, 6, 3, -1 }, new int[] { 11, 2, 2, 3, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0467822700738907, -0.335526704788208, 0.1495001018047333, new int[] { 21, 0, 12, 4, -1 }, new int[] { 21, 0, 6, 4, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0011599030112847686, -0.21494610607624051, 0.2950156033039093, new int[] { 12, 5, 2, 6, -1 }, new int[] { 12, 5, 1, 3, 2 }, new int[] { 13, 8, 1, 3, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0476444214582443, -0.17128750681877139, 0.0994972735643387, new int[] { 12, 4, 30, 3, -1 }, new int[] { 12, 4, 15, 3, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.062301728874445, -0.3829692006111145, 0.18469420075416571, new int[] { 4, 4, 30, 3, -1 }, new int[] { 19, 4, 15, 3, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0163931306451559, -0.487946093082428, 0.19131919741630549, new int[] { 39, 5, 6, 6, -1 }, new int[] { 39, 8, 6, 3, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0063293199054896832, -0.1820959001779556, 0.283134788274765, new int[] { 2, 3, 6, 4, -1 }, new int[] { 2, 3, 3, 2, 2 }, new int[] { 5, 5, 3, 2, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0064573478884994984, 0.0393458008766174, -0.52096349000930786, new int[] { 25, 0, 4, 1, -1 }, new int[] { 25, 0, 2, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0025518420152366161, 0.21809610724449161, -0.2021456062793732, new int[] { 12, 10, 12, 1, -1 }, new int[] { 15, 10, 6, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0026448559947311878, -0.0097657637670636177, -0.58440917730331421, new int[] { 27, 1, 2, 1, -1 }, new int[] { 27, 1, 1, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(3.3177100704051554E-05, -0.291212409734726, 0.13445389270782471, new int[] { 16, 1, 2, 1, -1 }, new int[] { 17, 1, 1, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0040287282317876816, 0.27975788712501531, -0.1085413992404938, new int[] { 20, 0, 18, 2, -1 }, new int[] { 29, 0, 9, 1, 2 }, new int[] { 20, 1, 9, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0017501820111647248, 0.0802451893687248, -0.5104030966758728, new int[] { 16, 9, 8, 2, -1 }, new int[] { 16, 9, 4, 1, 2 }, new int[] { 20, 10, 4, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.00982898660004139, 0.22203339636325839, -0.25279709696769709, true, new int[] { 35, 2, 4, 5, -1 }, new int[] { 36, 3, 2, 5, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0113553004339337, -0.5647733211517334, 0.0617882199585438, new int[] { 7, 0, 6, 3, -1 }, new int[] { 9, 0, 2, 3, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0061084949411451817, -0.12973600625991821, 0.31682729721069341, true, new int[] { 39, 3, 4, 3, -1 }, new int[] { 38, 4, 4, 1, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.00010406709770904854, 0.12907129526138311, -0.25948029756546021, true, new int[] { 14, 8, 1, 2, -1 }, new int[] { 14, 8, 1, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0026019159704446793, 0.0484216883778572, -0.54648971557617188, true, new int[] { 31, 7, 2, 2, -1 }, new int[] { 31, 7, 1, 2, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0059403157792985439, -0.55114412307739258, 0.0597233809530735, true, new int[] { 14, 7, 2, 2, -1 }, new int[] { 14, 7, 2, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0040788599289953709, 0.0797432884573936, -0.17927250266075129, new int[] { 32, 0, 6, 9, -1 }, new int[] { 34, 0, 2, 9, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.008813491091132164, 0.38017749786376948, -0.0863765701651573, true, new int[] { 12, 3, 3, 3, -1 }, new int[] { 13, 4, 1, 3, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0239835903048515, -0.49645310640335077, 0.054226141422987, new int[] { 14, 1, 18, 4, -1 }, new int[] { 23, 1, 9, 2, 2 }, new int[] { 14, 3, 9, 2, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0039569390937685966, 0.0516635812819004, -0.56799358129501343, new int[] { 8, 0, 4, 3, -1 }, new int[] { 9, 0, 2, 3, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.013359559699893, 0.2372480034828186, -0.0320837795734406, true, new int[] { 39, 3, 4, 3, -1 }, new int[] { 38, 4, 4, 1, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.008604658767580986, -0.0824632793664932, 0.40011510252952581, true, new int[] { 6, 3, 3, 4, -1 }, new int[] { 7, 4, 1, 4, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0084893424063920975, -0.52815818786621094, 0.0683831572532654, new int[] { 44, 0, 1, 8, -1 }, new int[] { 44, 4, 1, 4, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0077398498542606831, -0.43508920073509222, 0.0635677129030228, new int[] { 0, 5, 6, 6, -1 }, new int[] { 0, 8, 6, 3, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0054778340272605419, 0.0241151805967093, -0.45364230871200562, true, new int[] { 27, 0, 2, 2, -1 }, new int[] { 27, 0, 2, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0053739761933684349, -0.48526778817176819, 0.0625298321247101, true, new int[] { 18, 0, 2, 2, -1 }, new int[] { 18, 0, 1, 2, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0651551634073257, 0.33586868643760681, -0.1196988970041275, new int[] { 20, 3, 12, 8, -1 }, new int[] { 24, 3, 4, 8, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.003108280012384057, -0.0936680883169174, 0.31569510698318481, new int[] { 9, 0, 5, 2, -1 }, new int[] { 9, 1, 5, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0056411409750580788, 0.41902360320091248, -0.0524465292692184, new int[] { 34, 0, 4, 3, -1 }, new int[] { 34, 1, 4, 1, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.010050649754703, 0.0697155073285103, -0.482795000076294, new int[] { 0, 5, 1, 6, -1 }, new int[] { 0, 8, 1, 3, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.00064478779677301645, -0.39206001162528992, 0.0266355704516172, new int[] { 22, 9, 2, 2, -1 }, new int[] { 23, 9, 1, 1, 2 }, new int[] { 22, 10, 1, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(4.2866038711508736E-05, -0.28287550806999212, 0.0988063216209412, new int[] { 3, 9, 1, 2, -1 }, new int[] { 3, 10, 1, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0556598007678986, 0.0345925614237785, -0.57936602830886841, new int[] { 10, 3, 26, 6, -1 }, new int[] { 23, 3, 13, 3, 2 }, new int[] { 10, 6, 13, 3, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0190272405743599, 0.1279810965061188, -0.2225265055894852, new int[] { 10, 0, 11, 8, -1 }, new int[] { 10, 2, 11, 4, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0054886029101908207, 0.2212001979351044, -0.1424780935049057, true, new int[] { 40, 2, 3, 3, -1 }, new int[] { 39, 3, 3, 1, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0091977212578058243, 0.11419790238142009, -0.25367730855941772, new int[] { 4, 0, 20, 2, -1 }, new int[] { 9, 0, 10, 2, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.15616010129451749, -0.0246981307864189, 0.64977157115936279, new int[] { 21, 3, 12, 8, -1 }, new int[] { 25, 3, 4, 8, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.1039426997303963, -0.04759182035923, 0.670880913734436, new int[] { 12, 3, 12, 8, -1 }, new int[] { 16, 3, 4, 8, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.002372256014496088, -0.25346800684928888, 0.1275814026594162, new int[] { 15, 10, 15, 1, -1 }, new int[] { 20, 10, 5, 1, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0063766101375222206, -0.0806954428553581, 0.4279245138168335, true, new int[] { 5, 2, 3, 3, -1 }, new int[] { 6, 3, 1, 3, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0133687499910593, 0.1052142009139061, -0.0477701015770435, true, new int[] { 35, 2, 4, 3, -1 }, new int[] { 36, 3, 2, 3, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-5.6055800087051466E-05, 0.1201763972640038, -0.25983789563179022, new int[] { 2, 3, 2, 6, -1 }, new int[] { 3, 3, 1, 6, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0026153340004384518, 0.0496119409799576, -0.40553820133209229, new int[] { 18, 9, 10, 2, -1 }, new int[] { 23, 9, 5, 1, 2 }, new int[] { 18, 10, 5, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0008570487261749804, 0.3632655143737793, -0.082753598690033, new int[] { 5, 7, 2, 2, -1 }, new int[] { 5, 7, 1, 1, 2 }, new int[] { 6, 8, 1, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0040100780315697193, 0.0401565693318844, -0.56216222047805786, new int[] { 36, 8, 4, 3, -1 }, new int[] { 37, 8, 2, 3, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0157218798995018, -0.1180450022220612, 0.24654519557952881, new int[] { 20, 3, 4, 8, -1 }, new int[] { 22, 3, 2, 8, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0026668920181691647, -0.54068821668624878, 0.0436632893979549, new int[] { 36, 9, 4, 2, -1 }, new int[] { 37, 9, 2, 2, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.041414599865675, -0.0829768404364586, 0.33884221315383911, new int[] { 15, 5, 9, 6, -1 }, new int[] { 18, 5, 3, 6, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.004818757064640522, 0.0434143915772438, -0.40724611282348627, new int[] { 28, 0, 4, 4, -1 }, new int[] { 29, 0, 2, 4, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0054356600157916546, 0.33830219507217407, -0.0903681665658951, new int[] { 7, 2, 3, 3, -1 }, new int[] { 7, 3, 3, 1, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0046245800331234932, 0.0489254184067249, -0.1081843972206116, true, new int[] { 33, 2, 6, 1, -1 }, new int[] { 35, 4, 2, 1, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.00509105296805501, 0.33953168988227839, -0.0778475031256676, new int[] { 6, 0, 6, 3, -1 }, new int[] { 6, 1, 6, 1, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0069446121342480183, -0.36882779002189642, 0.0341559089720249, new int[] { 28, 0, 4, 4, -1 }, new int[] { 29, 0, 2, 4, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0052966130897402763, -0.46671220660209661, 0.0550306998193264, new int[] { 13, 0, 4, 4, -1 }, new int[] { 14, 0, 2, 4, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0082239676266908646, -0.0194188598543406, 0.27148181200027471, true, new int[] { 33, 2, 6, 1, -1 }, new int[] { 35, 4, 2, 1, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0069603421725332737, 0.13864019513130191, -0.21237270534038541, true, new int[] { 12, 2, 1, 6, -1 }, new int[] { 10, 4, 1, 2, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0035027971025556326, 0.48216879367828369, -0.0895727872848511, new int[] { 35, 1, 2, 3, -1 }, new int[] { 35, 2, 2, 1, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-3.356275919941254E-05, 0.17753930389881131, -0.1539040952920914, new int[] { 19, 8, 2, 2, -1 }, new int[] { 19, 8, 1, 1, 2 }, new int[] { 20, 9, 1, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0119058098644018, -0.44905489683151251, 0.0487651899456978, true, new int[] { 43, 6, 1, 4, -1 }, new int[] { 43, 6, 1, 2, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0010403740452602506, 0.0691993907094002, -0.39061141014099121, true, new int[] { 2, 6, 4, 1, -1 }, new int[] { 2, 6, 2, 1, 2 } ) });
            stage.Trees = nodes.ToArray(); stages.Add(stage);
            #endregion

            #region Stage 15
            stage = new HaarCascadeStage(-1.5824840068817139, 14, -1); nodes = new List<HaarFeatureNode[]>();
            nodes.Add(new[] { new HaarFeatureNode(0.1147755011916161, -0.35392341017723078, 0.24686269462108609, new int[] { 4, 3, 32, 3, -1 }, new int[] { 12, 3, 16, 3, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0083238538354635239, 0.35804480314254761, -0.29096409678459167, new int[] { 32, 5, 6, 2, -1 }, new int[] { 34, 5, 2, 2, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0330691784620285, -0.450177788734436, 0.14678280055522919, new int[] { 15, 0, 8, 7, -1 }, new int[] { 19, 0, 4, 7, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0098486011847853661, 0.15487630665302279, -0.15467190742492681, true, new int[] { 35, 2, 4, 3, -1 }, new int[] { 36, 3, 2, 3, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0036737930495291948, 0.2725059986114502, -0.20117540657520289, true, new int[] { 15, 2, 2, 3, -1 }, new int[] { 14, 3, 2, 1, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0035203520674258471, 0.2189404964447022, -0.30996188521385187, true, new int[] { 42, 5, 2, 3, -1 }, new int[] { 42, 5, 1, 3, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0029107630252838135, 0.17095150053501129, -0.25036340951919561, new int[] { 0, 1, 4, 6, -1 }, new int[] { 0, 1, 2, 3, 2 }, new int[] { 2, 4, 2, 3, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0111071700230241, -0.29383128881454468, 0.0905003175139427, new int[] { 13, 0, 21, 1, -1 }, new int[] { 20, 0, 7, 1, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0045277690514922142, -0.365673303604126, 0.0718126818537712, new int[] { 9, 4, 1, 6, -1 }, new int[] { 9, 7, 1, 3, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0016910480335354805, -0.24635620415210721, 0.1436509042978287, new int[] { 25, 9, 11, 2, -1 }, new int[] { 25, 10, 11, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.052848931401968, -0.489881306886673, 0.0588662698864937, new int[] { 9, 1, 26, 8, -1 }, new int[] { 9, 1, 13, 4, 2 }, new int[] { 22, 5, 13, 4, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0272572692483664, -0.13318820297718051, 0.1779861003160477, new int[] { 19, 5, 8, 6, -1 }, new int[] { 21, 5, 4, 6, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.10774610191583631, 0.75734657049179077, -0.045793280005455, new int[] { 15, 3, 12, 8, -1 }, new int[] { 21, 3, 6, 8, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.006236520130187273, 0.076347790658474, -0.46734619140625, new int[] { 20, 0, 6, 1, -1 }, new int[] { 22, 0, 2, 1, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0032917850185185671, 0.25657090544700623, -0.13669669628143311, new int[] { 7, 0, 12, 2, -1 }, new int[] { 7, 0, 6, 1, 2 }, new int[] { 13, 1, 6, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0070988652296364307, -0.73587757349014282, 0.0567887090146542, new int[] { 33, 9, 6, 2, -1 }, new int[] { 35, 9, 2, 2, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0205022394657135, -0.61333388090133667, 0.0406611002981663, new int[] { 11, 0, 6, 5, -1 }, new int[] { 13, 0, 2, 5, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0578949898481369, -0.42337441444396973, 0.0162566602230072, new int[] { 32, 1, 6, 10, -1 }, new int[] { 34, 1, 2, 10, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0070625008083879948, 0.1507007032632828, -0.21530729532241821, new int[] { 7, 1, 6, 10, -1 }, new int[] { 9, 1, 2, 10, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.001477460958994925, 0.0994475930929184, -0.19990250468254089, new int[] { 27, 0, 9, 3, -1 }, new int[] { 30, 0, 3, 3, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0059045450761914253, 0.23448540270328519, -0.13239750266075129, true, new int[] { 9, 3, 2, 3, -1 }, new int[] { 8, 4, 2, 1, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0049114958383142948, 0.0553076006472111, -0.41024419665336609, true, new int[] { 41, 0, 3, 2, -1 }, new int[] { 42, 1, 1, 2, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0403023585677147, 0.51089602708816528, -0.0671787187457085, new int[] { 6, 0, 5, 6, -1 }, new int[] { 6, 2, 5, 2, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0314785093069077, -0.35742738842964172, 0.034691110253334, new int[] { 27, 0, 9, 3, -1 }, new int[] { 30, 0, 3, 3, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.00020419940119609237, 0.1190790981054306, -0.26256930828094482, new int[] { 9, 0, 9, 3, -1 }, new int[] { 12, 0, 3, 3, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.00614961888641119, 0.0383449196815491, -0.70752871036529541, new int[] { 32, 9, 6, 2, -1 }, new int[] { 34, 9, 2, 2, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0064982818439602852, -0.57135289907455444, 0.0413468889892101, new int[] { 7, 9, 6, 2, -1 }, new int[] { 9, 9, 2, 2, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0020436770282685757, 0.21547719836235049, -0.0921439230442047, new int[] { 26, 10, 6, 1, -1 }, new int[] { 26, 10, 3, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0084923263639211655, 0.0570751093327999, -0.534873902797699, true, new int[] { 2, 0, 3, 2, -1 }, new int[] { 2, 0, 3, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0022661099210381508, 0.2737484872341156, -0.18907399475574491, true, new int[] { 32, 5, 3, 3, -1 }, new int[] { 31, 6, 3, 1, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0038180600386112928, -0.4999729990959168, 0.05628751963377, new int[] { 16, 9, 8, 2, -1 }, new int[] { 16, 9, 4, 1, 2 }, new int[] { 20, 10, 4, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.19832929968833921, -0.0492840297520161, 0.30991891026496893, new int[] { 18, 2, 12, 9, -1 }, new int[] { 22, 2, 4, 9, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0053573800250887871, 0.36525368690490723, -0.0815863236784935, new int[] { 8, 3, 2, 3, -1 }, new int[] { 8, 4, 2, 1, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0041200658306479454, -0.49979409575462341, 0.0337594412267208, new int[] { 43, 5, 2, 4, -1 }, new int[] { 43, 7, 2, 2, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0027241830248385668, -0.0749610364437103, 0.40402159094810491, new int[] { 8, 3, 2, 3, -1 }, new int[] { 8, 4, 2, 1, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0112792700529099, -0.62540912628173828, 0.0405392684042454, new int[] { 15, 4, 16, 2, -1 }, new int[] { 23, 4, 8, 1, 2 }, new int[] { 15, 5, 8, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.026438670232892, 0.6246979832649231, -0.0506956689059734, new int[] { 12, 5, 16, 2, -1 }, new int[] { 16, 5, 8, 2, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0930858105421066, -0.0277362298220396, 0.1220149993896484, new int[] { 19, 2, 9, 9, -1 }, new int[] { 22, 2, 3, 9, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.00036821569665335119, 0.0632278695702553, -0.45462760329246521, new int[] { 19, 9, 2, 2, -1 }, new int[] { 19, 9, 1, 1, 2 }, new int[] { 20, 10, 1, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0261502098292112, 0.21615530550479889, -0.0341892093420029, new int[] { 20, 1, 8, 10, -1 }, new int[] { 22, 1, 4, 10, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.15219129621982569, -0.56291139125823975, 0.050881389528513, new int[] { 0, 2, 39, 9, -1 }, new int[] { 13, 5, 13, 3, 9 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0053802412003278732, 0.1196914985775948, -0.0454637706279755, true, new int[] { 32, 5, 3, 3, -1 }, new int[] { 31, 6, 3, 1, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.003142140107229352, 0.0351711288094521, -0.75333297252655029, new int[] { 8, 9, 4, 2, -1 }, new int[] { 9, 9, 2, 2, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0023642999585717916, -0.0781453177332878, 0.0365911610424519, true, new int[] { 32, 5, 3, 3, -1 }, new int[] { 31, 6, 3, 1, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0034253650810569525, 0.27961251139640808, -0.10286819934844969, true, new int[] { 13, 5, 3, 3, -1 }, new int[] { 14, 6, 1, 3, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0101263895630836, 0.12946769595146179, -0.20795370638370511, new int[] { 24, 2, 11, 6, -1 }, new int[] { 24, 4, 11, 2, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0095109362155199051, -0.0644871667027473, 0.45304939150810242, true, new int[] { 5, 2, 3, 4, -1 }, new int[] { 6, 3, 1, 4, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0283829905092716, 0.18103609979152679, -0.12647239863872531, new int[] { 39, 1, 3, 9, -1 }, new int[] { 40, 4, 1, 3, 9 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0725912004709244, -0.13137449324131009, 0.2162660956382752, new int[] { 17, 2, 9, 9, -1 }, new int[] { 20, 2, 3, 9, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0056936382316052914, -0.0738181099295616, 0.1078862026333809, new int[] { 20, 8, 8, 2, -1 }, new int[] { 22, 8, 4, 2, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0054796910844743252, 0.41715219616889948, -0.0677783191204071, new int[] { 18, 7, 8, 4, -1 }, new int[] { 20, 7, 4, 4, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0680012926459312, -0.57230949401855469, 0.0596870183944702, new int[] { 8, 5, 30, 6, -1 }, new int[] { 23, 5, 15, 3, 2 }, new int[] { 8, 8, 15, 3, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(4.1796491132117808E-05, -0.3601624071598053, 0.0677706226706505, new int[] { 0, 7, 5, 2, -1 }, new int[] { 0, 8, 5, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0060458998195827007, -0.66702812910079956, 0.0206663999706507, true, new int[] { 23, 6, 1, 4, -1 }, new int[] { 22, 7, 1, 2, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.00089402851881459355, 0.18525250256061551, -0.13367660343647, new int[] { 3, 5, 3, 2, -1 }, new int[] { 4, 5, 1, 2, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0052337357774376869, -0.64259058237075806, 0.0382458008825779, new int[] { 21, 0, 6, 1, -1 }, new int[] { 23, 0, 2, 1, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0108766602352262, -0.65612989664077759, 0.0309162400662899, new int[] { 2, 3, 2, 7, -1 }, new int[] { 3, 3, 1, 7, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0107645904645324, -0.1220951974391937, 0.2324434965848923, new int[] { 18, 2, 24, 2, -1 }, new int[] { 30, 2, 12, 1, 2 }, new int[] { 18, 3, 12, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0062717488035559654, 0.0366653800010681, -0.64267098903656006, new int[] { 0, 3, 3, 4, -1 }, new int[] { 0, 4, 3, 2, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.00398709112778306, -0.1001384034752846, 0.26687619090080261, new int[] { 34, 0, 3, 3, -1 }, new int[] { 34, 1, 3, 1, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0056966538541018963, 0.0416801385581493, -0.62925517559051514, true, new int[] { 17, 1, 2, 2, -1 }, new int[] { 17, 1, 1, 2, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0024660900235176086, 0.30375760793685908, -0.0899545699357986, new int[] { 34, 0, 3, 3, -1 }, new int[] { 34, 1, 3, 1, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.00043577459291554987, 0.0568453297019005, -0.44916090369224548, new int[] { 21, 9, 2, 2, -1 }, new int[] { 21, 9, 1, 1, 2 }, new int[] { 22, 10, 1, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.00086022150935605168, -0.31331560015678411, 0.022231949493289, new int[] { 25, 9, 2, 2, -1 }, new int[] { 26, 9, 1, 1, 2 }, new int[] { 25, 10, 1, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-3.61517486453522E-05, 0.16037069261074069, -0.15645219385623929, new int[] { 18, 9, 2, 2, -1 }, new int[] { 18, 9, 1, 1, 2 }, new int[] { 19, 10, 1, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0012417449615895748, 0.36251470446586609, -0.0680296868085861, new int[] { 31, 4, 2, 2, -1 }, new int[] { 32, 4, 1, 1, 2 }, new int[] { 31, 5, 1, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0093716438859701157, -0.65667027235031128, 0.0392969995737076, true, new int[] { 4, 2, 1, 4, -1 }, new int[] { 3, 3, 1, 2, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.000506496406160295, -0.0998978018760681, 0.25486990809440607, new int[] { 31, 4, 2, 2, -1 }, new int[] { 32, 4, 1, 1, 2 }, new int[] { 31, 5, 1, 1, 2 } ) });
            stage.Trees = nodes.ToArray(); stages.Add(stage);
            #endregion

            #region Stage 16
            stage = new HaarCascadeStage(-1.4470269680023193, 15, -1); nodes = new List<HaarFeatureNode[]>();
            nodes.Add(new[] { new HaarFeatureNode(0.0069536222144961357, -0.30070298910140991, 0.28844910860061651, new int[] { 9, 1, 4, 6, -1 }, new int[] { 9, 1, 2, 3, 2 }, new int[] { 11, 4, 2, 3, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.155243992805481, -0.28483951091766357, 0.1254279017448425, new int[] { 19, 0, 20, 7, -1 }, new int[] { 19, 0, 10, 7, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0095990058034658432, 0.266362190246582, -0.22467589378356931, true, new int[] { 4, 2, 4, 3, -1 }, new int[] { 5, 3, 2, 3, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.000823255511932075, -0.15014129877090451, 0.1761123985052109, true, new int[] { 23, 6, 4, 1, -1 }, new int[] { 23, 6, 2, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0063837850466370583, -0.53211832046508789, 0.0889239236712456, new int[] { 0, 1, 2, 10, -1 }, new int[] { 0, 6, 2, 5, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0181104205548763, 0.29294028878211981, -0.1841827929019928, new int[] { 1, 10, 44, 1, -1 }, new int[] { 1, 10, 22, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0022221719846129417, 0.23608820140361789, -0.18082359433174131, new int[] { 12, 4, 4, 4, -1 }, new int[] { 13, 4, 2, 4, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.00427459878847003, 0.1137200966477394, -0.2823255062103272, new int[] { 30, 2, 12, 5, -1 }, new int[] { 33, 2, 6, 5, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0119243403896689, 0.30177098512649542, -0.1306345015764237, true, new int[] { 12, 2, 3, 4, -1 }, new int[] { 13, 3, 1, 4, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0021337319631129503, -0.2007887065410614, 0.1075965017080307, new int[] { 25, 9, 11, 2, -1 }, new int[] { 25, 10, 11, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(3.9748410927131772E-05, -0.33652520179748541, 0.0984087735414505, new int[] { 17, 1, 2, 1, -1 }, new int[] { 18, 1, 1, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0074939359910786152, 0.44728818535804749, -0.1235982030630112, new int[] { 33, 2, 4, 3, -1 }, new int[] { 33, 3, 4, 1, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0054673082195222378, -0.37992051243782038, 0.0901674702763557, true, new int[] { 18, 0, 2, 3, -1 }, new int[] { 18, 0, 1, 3, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.046410970389843, -0.47909379005432129, 0.0221620704978704, new int[] { 35, 0, 6, 6, -1 }, new int[] { 35, 0, 3, 6, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0018335790373384953, 0.14062260091304779, -0.27500510215759277, new int[] { 4, 0, 6, 6, -1 }, new int[] { 7, 0, 3, 6, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.00032272320822812617, 0.0443302914500237, -0.3167147040367127, new int[] { 22, 9, 2, 2, -1 }, new int[] { 23, 9, 1, 1, 2 }, new int[] { 22, 10, 1, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.002077614888548851, 0.41858351230621338, -0.0708758234977722, new int[] { 11, 5, 3, 2, -1 }, new int[] { 12, 5, 1, 2, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0079464362934231758, -0.79281628131866455, 0.0197782702744007, new int[] { 24, 9, 11, 2, -1 }, new int[] { 24, 10, 11, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.001816177973523736, -0.35335579514503479, 0.080757312476635, new int[] { 16, 0, 12, 1, -1 }, new int[] { 19, 0, 6, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.00013951859727967531, 0.0871761962771416, -0.2344271987676621, true, new int[] { 29, 5, 4, 2, -1 }, new int[] { 29, 5, 2, 2, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0030605921056121588, 0.1996555030345917, -0.144755095243454, new int[] { 14, 10, 9, 1, -1 }, new int[] { 17, 10, 3, 1, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.035044189542532, -0.46923148632049561, 0.0637441277503967, new int[] { 6, 7, 34, 4, -1 }, new int[] { 23, 7, 17, 2, 2 }, new int[] { 6, 9, 17, 2, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.2234399020671845, 0.0361883491277695, -0.67740142345428467, new int[] { 1, 2, 36, 4, -1 }, new int[] { 19, 2, 18, 4, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0062643741257488728, 0.0539225898683071, -0.29957211017608643, new int[] { 29, 0, 6, 4, -1 }, new int[] { 31, 0, 2, 4, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0051456191577017307, -0.0856956467032433, 0.3495860099792481, new int[] { 11, 5, 4, 2, -1 }, new int[] { 12, 5, 2, 2, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.00045792991295456886, -0.37274828553199768, 0.0520981289446354, new int[] { 22, 9, 2, 2, -1 }, new int[] { 23, 9, 1, 1, 2 }, new int[] { 22, 10, 1, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0089521985501050949, -0.5594332218170166, 0.0450372397899628, new int[] { 6, 8, 6, 3, -1 }, new int[] { 8, 8, 2, 3, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0088845528662204742, -0.82152491807937622, 0.019023310393095, new int[] { 33, 9, 6, 2, -1 }, new int[] { 35, 9, 2, 2, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.000839640386402607, 0.13553179800510409, -0.19439619779586789, new int[] { 0, 3, 2, 5, -1 }, new int[] { 1, 3, 1, 5, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0057581579312682152, 0.0348723717033863, -0.61317610740661621, new int[] { 33, 9, 6, 2, -1 }, new int[] { 35, 9, 2, 2, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.003297111950814724, 0.20933049917221069, -0.11797709763050079, new int[] { 7, 0, 16, 2, -1 }, new int[] { 7, 0, 8, 1, 2 }, new int[] { 15, 1, 8, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0066358018666505814, -0.12625180184841159, 0.2315140962600708, new int[] { 21, 1, 16, 2, -1 }, new int[] { 29, 1, 8, 1, 2 }, new int[] { 21, 2, 8, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0091771818697452545, 0.0422563590109348, -0.64281421899795532, true, new int[] { 16, 0, 2, 3, -1 }, new int[] { 16, 0, 1, 3, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0188983809202909, -0.54784798622131348, 0.0240227598696947, new int[] { 29, 0, 6, 4, -1 }, new int[] { 31, 0, 2, 4, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0139614399522543, 0.13342179358005521, -0.18949310481548309, new int[] { 12, 2, 6, 6, -1 }, new int[] { 14, 4, 2, 2, 9 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0039351810701191425, 0.0123231001198292, -0.48017400503158569, new int[] { 33, 10, 6, 1, -1 }, new int[] { 35, 10, 2, 1, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0028737629763782024, -0.0638331696391106, 0.38450908660888672, new int[] { 5, 3, 2, 3, -1 }, new int[] { 5, 4, 2, 1, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0021502410527318716, 0.249678298830986, -0.0836938619613647, new int[] { 39, 4, 1, 4, -1 }, new int[] { 39, 5, 1, 2, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0209453497081995, -0.46581479907035828, 0.0599679499864578, true, new int[] { 16, 4, 1, 6, -1 }, new int[] { 16, 4, 1, 3, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0012025360483676195, -0.0740314573049545, 0.26217839121818542, new int[] { 39, 4, 1, 4, -1 }, new int[] { 39, 5, 1, 2, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0012649910058826208, -0.56358098983764648, 0.0473508313298225, new int[] { 1, 8, 1, 3, -1 }, new int[] { 1, 9, 1, 1, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-3.5608751204563305E-05, 0.0839448198676109, -0.0923392772674561, new int[] { 25, 8, 2, 2, -1 }, new int[] { 26, 8, 1, 1, 2 }, new int[] { 25, 9, 1, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0017638429999351502, -0.067106232047081, 0.353906512260437, new int[] { 5, 4, 1, 4, -1 }, new int[] { 5, 5, 1, 2, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0026478520594537258, 0.0497924908995628, -0.5610852837562561, new int[] { 42, 8, 2, 3, -1 }, new int[] { 42, 9, 2, 1, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0011421759845688939, -0.0805669277906418, 0.31899300217628479, new int[] { 5, 4, 2, 2, -1 }, new int[] { 5, 4, 1, 1, 2 }, new int[] { 6, 5, 1, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0037144690286368132, -0.21286490559577939, 0.0669720098376274, true, new int[] { 42, 2, 2, 2, -1 }, new int[] { 42, 2, 1, 2, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0046520791947841644, 0.0592891909182072, -0.45674440264701838, true, new int[] { 3, 2, 2, 2, -1 }, new int[] { 3, 2, 2, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0047056251205503941, -0.24541069567203519, 0.0245448406785727, new int[] { 33, 9, 6, 2, -1 }, new int[] { 35, 9, 2, 2, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0071251969784498215, 0.0383189283311367, -0.64973872900009155, new int[] { 6, 9, 6, 2, -1 }, new int[] { 8, 9, 2, 2, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0676583871245384, 0.40030410885810852, -0.0320798717439175, true, new int[] { 28, 3, 2, 6, -1 }, new int[] { 28, 3, 2, 3, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0357298403978348, -0.0704301074147224, 0.30633118748664862, new int[] { 16, 4, 8, 7, -1 }, new int[] { 18, 4, 4, 7, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0338284410536289, 0.50491297245025635, -0.0354564599692822, new int[] { 21, 1, 6, 8, -1 }, new int[] { 21, 1, 3, 8, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0133518604561687, -0.178902804851532, 0.14767180383205411, new int[] { 18, 4, 6, 4, -1 }, new int[] { 21, 4, 3, 4, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0874881967902184, 0.0435387790203094, -0.46793699264526373, true, new int[] { 24, 0, 8, 3, -1 }, new int[] { 24, 0, 4, 3, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0036777120549231768, -0.20427100360393519, 0.15148130059242251, new int[] { 1, 9, 32, 2, -1 }, new int[] { 9, 9, 16, 2, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0010766600025817752, -0.0963197872042656, 0.35530230402946472, new int[] { 38, 2, 1, 3, -1 }, new int[] { 38, 3, 1, 1, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0052243531681597233, 0.0533896684646606, -0.45717859268188482, true, new int[] { 15, 0, 3, 2, -1 }, new int[] { 16, 1, 1, 2, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0095345107838511467, 0.149124801158905, -0.14985750615596771, true, new int[] { 32, 2, 6, 1, -1 }, new int[] { 34, 4, 2, 1, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(4.257301043253392E-05, -0.1389053016901016, 0.1546718031167984, new int[] { 0, 10, 2, 1, -1 }, new int[] { 1, 10, 1, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0015596169978380203, -0.54723149538040161, 0.034767109900713, new int[] { 43, 9, 2, 2, -1 }, new int[] { 43, 10, 2, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0007622211123816669, -0.0789805501699448, 0.28355160355567932, new int[] { 7, 3, 2, 2, -1 }, new int[] { 7, 3, 1, 1, 2 }, new int[] { 8, 4, 1, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0219077207148075, -0.43671789765357971, 0.0517012402415276, new int[] { 21, 0, 3, 9, -1 }, new int[] { 22, 3, 1, 3, 9 } ) });
            nodes.Add(new[] { new HaarFeatureNode(4.6507688239216805E-05, -0.31914091110229492, 0.0624821111559868, new int[] { 0, 8, 5, 2, -1 }, new int[] { 0, 9, 5, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.00029253138927742839, -0.247669905424118, 0.0840149372816086, new int[] { 42, 8, 2, 3, -1 }, new int[] { 42, 9, 2, 1, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0030009269248694181, -0.11042869836092, 0.19720460474491119, true, new int[] { 9, 5, 1, 4, -1 }, new int[] { 8, 6, 1, 2, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.00087042397353798151, 0.0671973675489426, -0.18366929888725281, new int[] { 42, 8, 2, 3, -1 }, new int[] { 42, 9, 2, 1, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.00076602102490141988, -0.064485676586628, 0.32467260956764221, new int[] { 11, 7, 2, 2, -1 }, new int[] { 11, 7, 1, 1, 2 }, new int[] { 12, 8, 1, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(3.3248408726649359E-05, -0.0983626469969749, 0.0864629372954369, new int[] { 43, 8, 1, 3, -1 }, new int[] { 43, 9, 1, 1, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0012568470556288958, 0.0493546798825264, -0.43177890777587891, new int[] { 1, 8, 1, 3, -1 }, new int[] { 1, 9, 1, 1, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0097309090197086334, -0.27393120527267462, 0.0396414399147034, new int[] { 36, 0, 6, 4, -1 }, new int[] { 38, 0, 2, 4, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0058255670592188835, -0.0703800767660141, 0.30546179413795471, new int[] { 4, 0, 12, 2, -1 }, new int[] { 4, 0, 6, 1, 2 }, new int[] { 10, 1, 6, 1, 2 } ) });
            stage.Trees = nodes.ToArray(); stages.Add(stage);
            #endregion

            #region Stage 17
            stage = new HaarCascadeStage(-1.4913309812545776, 16, -1); nodes = new List<HaarFeatureNode[]>();
            nodes.Add(new[] { new HaarFeatureNode(-0.0069308779202401638, 0.23897680640220639, -0.33735579252243042, new int[] { 6, 4, 6, 4, -1 }, new int[] { 8, 4, 2, 4, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0063356258906424046, -0.2060621976852417, 0.24546289443969729, new int[] { 34, 0, 10, 4, -1 }, new int[] { 34, 1, 10, 2, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0329519286751747, -0.48151299357414251, 0.13534410297870639, new int[] { 12, 0, 12, 4, -1 }, new int[] { 18, 0, 6, 4, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0202942993491888, 0.24425999820232391, -0.3064855039119721, new int[] { 39, 1, 3, 9, -1 }, new int[] { 40, 4, 1, 3, 9 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0080935731530189514, 0.21754260361194611, -0.2305133938789368, new int[] { 6, 2, 8, 4, -1 }, new int[] { 6, 3, 8, 2, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0032209409400820732, 0.24082750082015991, -0.14753510057926181, true, new int[] { 31, 5, 3, 3, -1 }, new int[] { 30, 6, 3, 1, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0369491204619408, -0.28758960962295532, 0.17237929999828339, new int[] { 0, 5, 24, 2, -1 }, new int[] { 12, 5, 12, 2, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0010001210030168295, -0.18483549356460571, 0.106496699154377, new int[] { 24, 5, 2, 2, -1 }, new int[] { 24, 5, 1, 2, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-4.9832418881123886E-05, 0.10084930062294011, -0.3728978037834168, true, new int[] { 15, 4, 3, 4, -1 }, new int[] { 15, 4, 3, 2, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0466450713574886, 0.0713314116001129, -0.421749085187912, new int[] { 10, 1, 26, 8, -1 }, new int[] { 23, 1, 13, 4, 2 }, new int[] { 10, 5, 13, 4, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0029729669913649559, -0.23385779559612269, 0.15728150308132169, new int[] { 0, 5, 4, 6, -1 }, new int[] { 0, 5, 2, 3, 2 }, new int[] { 2, 8, 2, 3, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0011885419953614473, -0.21615119278430939, 0.0854354798793793, new int[] { 24, 9, 11, 2, -1 }, new int[] { 24, 10, 11, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0025504899676889181, 0.2445300966501236, -0.1364232003688812, new int[] { 9, 4, 4, 3, -1 }, new int[] { 10, 4, 2, 3, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0145806903019547, 0.0630506128072739, -0.43805420398712158, new int[] { 44, 3, 1, 8, -1 }, new int[] { 44, 7, 1, 4, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.00017621000006329268, -0.3502649068832398, 0.0979951471090317, new int[] { 0, 3, 1, 8, -1 }, new int[] { 0, 7, 1, 4, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0107630603015423, -0.55614972114562988, 0.0526131093502045, new int[] { 33, 0, 6, 3, -1 }, new int[] { 35, 0, 2, 3, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0017733459826558828, 0.2124083936214447, -0.12885910272598269, true, new int[] { 13, 6, 3, 2, -1 }, new int[] { 14, 7, 1, 2, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.005617022980004549, -0.57895171642303467, 0.0270562805235386, new int[] { 20, 8, 8, 2, -1 }, new int[] { 24, 8, 4, 1, 2 }, new int[] { 20, 9, 4, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.78137779235839844, 0.0435121916234493, -0.511123776435852, new int[] { 0, 1, 45, 9, -1 }, new int[] { 15, 4, 15, 3, 9 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0155215598642826, 0.0178874898701906, -0.42302969098091131, new int[] { 33, 0, 6, 3, -1 }, new int[] { 35, 0, 2, 3, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0060149789787828922, -0.61993318796157837, 0.041468121111393, new int[] { 16, 8, 10, 2, -1 }, new int[] { 16, 8, 5, 1, 2 }, new int[] { 21, 9, 5, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0120329596102238, 0.37520378828048712, -0.0521019399166107, new int[] { 22, 0, 4, 9, -1 }, new int[] { 22, 0, 2, 9, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.00057090952759608626, -0.2300080060958862, 0.13806359469890589, true, new int[] { 22, 6, 1, 4, -1 }, new int[] { 22, 6, 1, 2, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-3.5141059925081208E-05, 0.136135995388031, -0.13633610308170321, new int[] { 23, 8, 2, 2, -1 }, new int[] { 24, 8, 1, 1, 2 }, new int[] { 23, 9, 1, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.00038827958633191884, 0.0620439797639847, -0.40999558568000788, new int[] { 20, 8, 2, 2, -1 }, new int[] { 20, 8, 1, 1, 2 }, new int[] { 21, 9, 1, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0031813879031687975, 0.43042609095573431, -0.0585743896663189, new int[] { 37, 4, 4, 2, -1 }, new int[] { 39, 4, 2, 1, 2 }, new int[] { 37, 5, 2, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0123597597703338, -0.0534252189099789, 0.44235768914222717, new int[] { 6, 2, 6, 3, -1 }, new int[] { 6, 3, 6, 1, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.00536307692527771, 0.0483457297086716, -0.3691985011100769, true, new int[] { 29, 1, 3, 2, -1 }, new int[] { 29, 1, 3, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0067529240623116493, -0.0677888989448547, 0.40632560849189758, new int[] { 0, 3, 10, 2, -1 }, new int[] { 0, 3, 5, 1, 2 }, new int[] { 5, 4, 5, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0115061802789569, -0.24940669536590579, 0.0300437901169062, new int[] { 36, 0, 6, 4, -1 }, new int[] { 38, 0, 2, 4, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0065450267866253853, -0.5039336085319519, 0.0510484091937542, new int[] { 0, 1, 1, 6, -1 }, new int[] { 0, 4, 1, 3, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.006405950989574194, -0.78335607051849365, 0.00708061782643199, new int[] { 36, 10, 6, 1, -1 }, new int[] { 38, 10, 2, 1, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.00472799688577652, -0.6846734881401062, 0.0338671393692493, new int[] { 3, 10, 6, 1, -1 }, new int[] { 5, 10, 2, 1, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.00052285747369751334, 0.14660769701004031, -0.0672899633646011, new int[] { 33, 7, 2, 2, -1 }, new int[] { 34, 7, 1, 1, 2 }, new int[] { 33, 8, 1, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0093035101890563965, -0.40989071130752558, 0.0572993196547031, new int[] { 3, 0, 6, 4, -1 }, new int[] { 5, 0, 2, 4, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0068128891289234161, 0.0429198816418648, -0.247306302189827, new int[] { 36, 0, 6, 3, -1 }, new int[] { 38, 0, 2, 3, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.00046791278873570263, -0.0759941563010216, 0.30771958827972412, new int[] { 10, 7, 2, 2, -1 }, new int[] { 10, 7, 1, 1, 2 }, new int[] { 11, 8, 1, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0234316699206829, 0.0105453496798873, -0.41394978761672968, new int[] { 36, 0, 6, 3, -1 }, new int[] { 38, 0, 2, 3, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0092174801975488663, 0.0580441802740097, -0.40034890174865723, new int[] { 3, 0, 6, 3, -1 }, new int[] { 5, 0, 2, 3, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.00783718191087246, 0.12945890426635739, -0.0732556134462357, new int[] { 33, 0, 8, 2, -1 }, new int[] { 33, 0, 4, 2, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0035635009407997131, -0.0714029222726822, 0.347095787525177, new int[] { 5, 6, 4, 2, -1 }, new int[] { 5, 6, 2, 1, 2 }, new int[] { 7, 7, 2, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0053719929419457912, 0.0697310492396355, -0.061688169836998, new int[] { 31, 0, 10, 2, -1 }, new int[] { 31, 0, 5, 2, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0432901903986931, 0.0503349713981152, -0.45517569780349731, new int[] { 13, 0, 18, 6, -1 }, new int[] { 13, 0, 9, 3, 2 }, new int[] { 22, 3, 9, 3, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0046179331839084625, -0.4911034107208252, 0.0359277799725533, true, new int[] { 26, 0, 1, 2, -1 }, new int[] { 26, 0, 1, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.00700185215100646, -0.60634332895278931, 0.0330439507961273, true, new int[] { 15, 7, 2, 2, -1 }, new int[] { 15, 7, 2, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0205463208258152, 0.37467220425605768, -0.0609663501381874, true, new int[] { 41, 0, 4, 4, -1 }, new int[] { 40, 1, 4, 2, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.009015355259180069, -0.0813770294189453, 0.28447070717811579, true, new int[] { 4, 0, 4, 4, -1 }, new int[] { 5, 1, 2, 4, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0169452708214521, 0.0199470799416304, -0.42220640182495123, new int[] { 25, 9, 11, 2, -1 }, new int[] { 25, 10, 11, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.00082118361024186015, -0.27205279469490051, 0.0955905392765999, new int[] { 9, 9, 11, 2, -1 }, new int[] { 9, 10, 11, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(3.5344670322956517E-05, -0.0796178579330444, 0.074185736477375, new int[] { 24, 1, 2, 2, -1 }, new int[] { 25, 1, 1, 1, 2 }, new int[] { 24, 2, 1, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.084219790995121, -0.48575800657272339, 0.0422429405152798, new int[] { 0, 0, 44, 6, -1 }, new int[] { 0, 0, 22, 3, 2 }, new int[] { 22, 3, 22, 3, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0435173399746418, -0.1548252999782562, 0.1075984016060829, new int[] { 20, 0, 8, 11, -1 }, new int[] { 20, 0, 4, 11, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0083383917808532715, 0.40242099761962891, -0.0837341472506523, new int[] { 17, 4, 8, 7, -1 }, new int[] { 19, 4, 4, 7, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0026848739944398403, 0.25776070356369019, -0.0573123209178448, new int[] { 34, 7, 4, 3, -1 }, new int[] { 34, 8, 4, 1, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0039407201111316681, -0.0959949418902397, 0.249248206615448, new int[] { 7, 7, 4, 3, -1 }, new int[] { 7, 8, 4, 1, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.000658828008454293, 0.12785859405994421, -0.15311600267887121, new int[] { 29, 0, 3, 7, -1 }, new int[] { 30, 0, 1, 7, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0118757104501128, -0.70702570676803589, 0.0329137407243252, new int[] { 13, 0, 3, 7, -1 }, new int[] { 14, 0, 1, 7, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0239820200949907, -0.50821501016616821, 0.0465518310666084, new int[] { 14, 6, 18, 4, -1 }, new int[] { 23, 6, 9, 2, 2 }, new int[] { 14, 8, 9, 2, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0020041069947183132, -0.68692350387573242, 0.0257601495832205, new int[] { 9, 9, 4, 1, -1 }, new int[] { 10, 9, 2, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0078222304582595825, -0.0481032282114029, 0.21432960033416751, new int[] { 23, 8, 6, 3, -1 }, new int[] { 25, 8, 2, 3, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0109465699642897, -0.16195610165596011, 0.1688020974397659, new int[] { 18, 3, 6, 5, -1 }, new int[] { 20, 3, 2, 5, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0268028602004051, 0.0562569610774517, -0.275054007768631, true, new int[] { 23, 0, 10, 1, -1 }, new int[] { 23, 0, 5, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0039884559810161591, -0.1266321986913681, 0.21626690030097959, new int[] { 21, 0, 2, 11, -1 }, new int[] { 22, 0, 1, 11, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0180086903274059, 0.14534379541873929, -0.0554223097860813, new int[] { 22, 7, 9, 3, -1 }, new int[] { 25, 7, 3, 3, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0171894803643227, -0.0676231905817986, 0.40081891417503362, new int[] { 14, 7, 9, 3, -1 }, new int[] { 17, 7, 3, 3, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0122314803302288, -0.82071441411972046, 0.0212977807968855, new int[] { 20, 0, 6, 2, -1 }, new int[] { 22, 0, 2, 2, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0158304795622826, 0.0352074205875397, -0.605314314365387, new int[] { 19, 0, 6, 2, -1 }, new int[] { 21, 0, 2, 2, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0152642698958516, -0.27459529042243958, 0.0226070396602154, true, new int[] { 23, 0, 10, 1, -1 }, new int[] { 23, 0, 5, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0388083383440971, 0.0396233908832073, -0.58665269613265991, true, new int[] { 22, 0, 1, 10, -1 }, new int[] { 22, 0, 1, 5, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0016585539560765028, 0.0249276999384165, -0.17679250240325931, new int[] { 22, 1, 4, 1, -1 }, new int[] { 23, 1, 2, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0070774480700492859, 0.39536350965499878, -0.0545681081712246, new int[] { 7, 0, 5, 3, -1 }, new int[] { 7, 1, 5, 1, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(4.7583471314283088E-05, -0.090718649327755, 0.0676982626318932, new int[] { 22, 1, 4, 1, -1 }, new int[] { 23, 1, 2, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(4.461927164811641E-05, -0.2377043962478638, 0.0997626781463623, new int[] { 18, 1, 6, 1, -1 }, new int[] { 20, 1, 2, 1, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0118510304018855, 0.32351729273796082, -0.0395865589380264, new int[] { 21, 0, 16, 2, -1 }, new int[] { 29, 0, 8, 1, 2 }, new int[] { 21, 1, 8, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0016401939792558551, -0.29881209135055542, 0.0734669119119644, true, new int[] { 14, 2, 2, 1, -1 }, new int[] { 14, 2, 1, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0069199479185044765, 0.43420779705047607, -0.1028432995080948, new int[] { 33, 1, 6, 3, -1 }, new int[] { 33, 2, 6, 1, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0114842597395182, -0.49977409839630133, 0.0500394888222218, true, new int[] { 15, 1, 4, 2, -1 }, new int[] { 16, 2, 2, 2, 2 } ) });
            stage.Trees = nodes.ToArray(); stages.Add(stage);
            #endregion

            #region Stage 18
            stage = new HaarCascadeStage(-1.4498629570007324, 17, -1); nodes = new List<HaarFeatureNode[]>();
            nodes.Add(new[] { new HaarFeatureNode(0.0057978169061243534, -0.25478368997573853, 0.31262540817260742, true, new int[] { 13, 3, 3, 4, -1 }, new int[] { 14, 4, 1, 4, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0034410690423101187, -0.14427100121974951, 0.14882120490074161, new int[] { 36, 0, 8, 4, -1 }, new int[] { 36, 1, 8, 2, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.16638059914112091, -0.290010005235672, 0.1731016933917999, new int[] { 7, 0, 18, 7, -1 }, new int[] { 16, 0, 9, 7, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0074716238304972649, 0.25105801224708563, -0.20066189765930181, true, new int[] { 38, 2, 6, 1, -1 }, new int[] { 40, 4, 2, 1, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0036712910514324903, 0.25619038939476008, -0.1986774951219559, new int[] { 3, 5, 4, 6, -1 }, new int[] { 3, 5, 2, 3, 2 }, new int[] { 5, 8, 2, 3, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.00018908550555352122, -0.126316100358963, 0.1122589036822319, true, new int[] { 24, 8, 2, 1, -1 }, new int[] { 24, 8, 1, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.00195624609477818, 0.22644129395484919, -0.16129520535469061, new int[] { 13, 10, 12, 1, -1 }, new int[] { 16, 10, 6, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0081449178978800774, 0.25742760300636292, -0.0721231773495674, new int[] { 34, 0, 10, 4, -1 }, new int[] { 34, 1, 10, 2, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0064932177774608135, -0.18143969774246221, 0.22572280466556549, new int[] { 1, 0, 10, 4, -1 }, new int[] { 1, 1, 10, 2, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.000453875312814489, 0.0236864201724529, -0.40528649091720581, new int[] { 22, 9, 2, 2, -1 }, new int[] { 23, 9, 1, 1, 2 }, new int[] { 22, 10, 1, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(4.2509411287028342E-05, -0.29150670766830439, 0.1111551970243454, new int[] { 4, 9, 1, 2, -1 }, new int[] { 4, 10, 1, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0157671198248863, -0.73671698570251465, 0.0103860199451447, new int[] { 33, 0, 6, 3, -1 }, new int[] { 35, 0, 2, 3, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0069369110278785229, 0.16062590479850769, -0.18799079954624179, true, new int[] { 7, 0, 7, 3, -1 }, new int[] { 6, 1, 7, 1, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0032210960052907467, 0.116404302418232, -0.18258500099182129, new int[] { 27, 0, 12, 2, -1 }, new int[] { 30, 0, 6, 2, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0121315596625209, -0.63532382249832153, 0.0353767983615398, new int[] { 6, 0, 6, 3, -1 }, new int[] { 8, 0, 2, 3, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.00026418970082886517, -0.24938230216503141, 0.0558976009488106, new int[] { 22, 9, 2, 2, -1 }, new int[] { 23, 9, 1, 1, 2 }, new int[] { 22, 10, 1, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.1173785999417305, 0.0312053691595793, -0.74014288187026978, new int[] { 3, 4, 34, 2, -1 }, new int[] { 20, 4, 17, 2, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0011690290411934257, 0.0785990729928017, -0.17284469306468961, new int[] { 22, 5, 6, 6, -1 }, new int[] { 25, 5, 3, 3, 2 }, new int[] { 22, 8, 3, 3, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0247644707560539, 0.0510483793914318, -0.51298439502716064, new int[] { 12, 4, 20, 4, -1 }, new int[] { 12, 4, 10, 2, 2 }, new int[] { 22, 6, 10, 2, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0042942222207784653, 0.3229491114616394, -0.0915554165840149, new int[] { 37, 2, 2, 3, -1 }, new int[] { 37, 3, 2, 1, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0123548898845911, -0.0710467174649239, 0.3719576895236969, new int[] { 5, 2, 9, 3, -1 }, new int[] { 5, 3, 9, 1, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0231044609099627, -0.59680628776550293, 0.0121953804045916, new int[] { 27, 0, 12, 1, -1 }, new int[] { 30, 0, 6, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.002012202050536871, 0.13106389343738559, -0.20082409679889679, new int[] { 6, 0, 12, 1, -1 }, new int[] { 9, 0, 6, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0121228098869324, -0.33110201358795172, 0.0324316583573818, new int[] { 30, 0, 6, 3, -1 }, new int[] { 32, 0, 2, 3, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0139670297503471, -0.47931128740310669, 0.0521073900163174, new int[] { 8, 0, 6, 4, -1 }, new int[] { 10, 0, 2, 4, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0075348587706685066, -0.0988587886095047, 0.36169511079788208, true, new int[] { 34, 3, 3, 3, -1 }, new int[] { 33, 4, 3, 1, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0168277490884066, -0.61323410272598267, 0.0437193810939789, new int[] { 10, 0, 6, 4, -1 }, new int[] { 12, 0, 2, 4, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.00546553498134017, 0.0292573906481266, -0.4150238037109375, new int[] { 36, 9, 6, 2, -1 }, new int[] { 38, 9, 2, 2, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0057378439232707024, -0.49381670355796808, 0.0447048582136631, new int[] { 3, 9, 6, 2, -1 }, new int[] { 5, 9, 2, 2, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.00995110534131527, 0.3104512095451355, -0.0606985986232758, true, new int[] { 34, 3, 3, 3, -1 }, new int[] { 33, 4, 3, 1, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0028865570202469826, -0.19001829624176031, 0.12568040192127231, new int[] { 16, 10, 12, 1, -1 }, new int[] { 19, 10, 6, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0411295108497143, 0.030545100569725, -0.420065313577652, true, new int[] { 23, 0, 1, 10, -1 }, new int[] { 23, 0, 1, 5, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.16931550204753881, 0.0329228602349758, -0.70118480920791626, new int[] { 1, 5, 32, 4, -1 }, new int[] { 9, 5, 16, 4, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0391142293810844, -0.1238982975482941, 0.25299561023712158, new int[] { 20, 1, 6, 10, -1 }, new int[] { 20, 1, 3, 10, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.1416721045970917, -0.1185699999332428, 0.26716861128807068, new int[] { 0, 6, 44, 5, -1 }, new int[] { 22, 6, 22, 5, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.002325722947716713, 0.0279077496379614, -0.3400920033454895, new int[] { 33, 10, 6, 1, -1 }, new int[] { 35, 10, 2, 1, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0262453891336918, 0.0982663780450821, -0.2575640082359314, new int[] { 0, 3, 18, 4, -1 }, new int[] { 6, 3, 6, 4, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0018283349927514792, -0.0837034434080124, 0.23101350665092471, new int[] { 30, 3, 4, 2, -1 }, new int[] { 32, 3, 2, 1, 2 }, new int[] { 30, 4, 2, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0047496692277491093, 0.0613271296024323, -0.4359326958656311, true, new int[] { 4, 0, 3, 4, -1 }, new int[] { 3, 1, 3, 2, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0043565989471971989, -0.42383280396461492, 0.009438222274184227, new int[] { 33, 10, 6, 1, -1 }, new int[] { 35, 10, 2, 1, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0038147179875522852, -0.6463773250579834, 0.037270799279213, new int[] { 6, 10, 6, 1, -1 }, new int[] { 8, 10, 2, 1, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0021859859116375446, 0.28486278653144842, -0.1957722008228302, new int[] { 28, 5, 4, 3, -1 }, new int[] { 29, 5, 2, 3, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0015153910499066114, 0.1678110063076019, -0.13713860511779791, new int[] { 13, 5, 4, 3, -1 }, new int[] { 14, 5, 2, 3, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-3.2454739994136617E-05, 0.0736324116587639, -0.0777876824140549, new int[] { 25, 8, 2, 2, -1 }, new int[] { 26, 8, 1, 1, 2 }, new int[] { 25, 9, 1, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0118858404457569, -0.0431110896170139, 0.52360087633132935, true, new int[] { 11, 3, 3, 3, -1 }, new int[] { 12, 4, 1, 3, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0044173169881105423, 0.0458498001098633, -0.32220908999443049, true, new int[] { 28, 0, 2, 3, -1 }, new int[] { 27, 1, 2, 1, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0073544741608202457, -0.076994776725769, 0.28344219923019409, true, new int[] { 4, 1, 3, 3, -1 }, new int[] { 5, 2, 1, 3, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0141299199312925, -0.39489749073982239, 0.04176190122962, new int[] { 43, 3, 2, 6, -1 }, new int[] { 43, 5, 2, 2, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0063752778805792332, 0.0469008199870586, -0.485403299331665, new int[] { 0, 3, 2, 6, -1 }, new int[] { 0, 5, 2, 2, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0023776849266141653, 0.0173678006976843, -0.20004540681838989, true, new int[] { 28, 6, 2, 1, -1 }, new int[] { 28, 6, 1, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0095808254554867744, 0.36303970217704767, -0.0628790184855461, new int[] { 17, 7, 9, 4, -1 }, new int[] { 20, 7, 3, 4, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(3.8879989006090909E-05, -0.0812498107552528, 0.0810688734054565, new int[] { 24, 1, 2, 2, -1 }, new int[] { 25, 1, 1, 1, 2 }, new int[] { 24, 2, 1, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0880179926753044, 0.4444068968296051, -0.0485203489661217, true, new int[] { 18, 2, 6, 3, -1 }, new int[] { 18, 2, 3, 3, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0014197609852999449, -0.105834499001503, 0.23807370662689209, new int[] { 38, 4, 4, 2, -1 }, new int[] { 40, 4, 2, 1, 2 }, new int[] { 38, 5, 2, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0082073677331209183, 0.0479943305253983, -0.46953499317169189, new int[] { 14, 3, 16, 2, -1 }, new int[] { 14, 3, 8, 1, 2 }, new int[] { 22, 4, 8, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0029159379191696644, 0.37838110327720642, -0.0608552396297455, new int[] { 38, 4, 4, 2, -1 }, new int[] { 40, 4, 2, 1, 2 }, new int[] { 38, 5, 2, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0122875003144145, 0.12594810128211981, -0.177018404006958, new int[] { 12, 0, 3, 9, -1 }, new int[] { 13, 3, 1, 3, 9 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0056836591102182865, 0.23341970145702359, -0.0444960817694664, new int[] { 33, 0, 6, 3, -1 }, new int[] { 33, 1, 6, 1, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0139244701713324, -0.72878497838974, 0.0307584293186665, true, new int[] { 15, 0, 3, 3, -1 }, new int[] { 16, 1, 1, 3, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0099232727661728859, -0.0393612012267113, 0.34838870167732239, true, new int[] { 31, 2, 3, 3, -1 }, new int[] { 32, 3, 1, 3, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0106927696615458, -0.0442237891256809, 0.42715668678283691, true, new int[] { 14, 2, 3, 3, -1 }, new int[] { 13, 3, 3, 1, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(3.7554800655925646E-05, -0.0644943863153458, 0.12572330236434939, new int[] { 23, 9, 2, 2, -1 }, new int[] { 24, 9, 1, 1, 2 }, new int[] { 23, 10, 1, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.00027551440871320665, 0.0674459934234619, -0.34731999039649958, new int[] { 20, 9, 2, 2, -1 }, new int[] { 20, 9, 1, 1, 2 }, new int[] { 21, 10, 1, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(3.5946661228081211E-05, -0.0758708491921425, 0.124957799911499, new int[] { 25, 8, 2, 2, -1 }, new int[] { 26, 8, 1, 1, 2 }, new int[] { 25, 9, 1, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-4.1565788706066087E-05, 0.14327770471572879, -0.15775039792060849, new int[] { 18, 8, 2, 2, -1 }, new int[] { 18, 8, 1, 1, 2 }, new int[] { 19, 9, 1, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0029380898922681808, -0.28900629281997681, 0.0645285025238991, new int[] { 17, 0, 12, 2, -1 }, new int[] { 20, 0, 6, 2, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.233806699514389, -0.0380702316761017, 0.6060631275177002, new int[] { 8, 0, 18, 11, -1 }, new int[] { 14, 0, 6, 11, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-4.0552138671046123E-05, 0.1788138002157211, -0.0939079597592354, new int[] { 24, 1, 2, 2, -1 }, new int[] { 25, 1, 1, 1, 2 }, new int[] { 24, 2, 1, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(3.6401779652806E-05, -0.17232389748096469, 0.14596420526504519, new int[] { 19, 1, 2, 2, -1 }, new int[] { 19, 1, 1, 1, 2 }, new int[] { 20, 2, 1, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0122575396671891, 0.0273588206619024, -0.59449177980422974, new int[] { 30, 8, 6, 3, -1 }, new int[] { 32, 8, 2, 3, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(3.4914221032522619E-05, -0.14092069864273071, 0.141100600361824, new int[] { 19, 3, 2, 2, -1 }, new int[] { 19, 3, 1, 1, 2 }, new int[] { 20, 4, 1, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.00507042882964015, -0.11959090083837511, 0.33249089121818542, new int[] { 26, 1, 10, 2, -1 }, new int[] { 31, 1, 5, 1, 2 }, new int[] { 26, 2, 5, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0128887603059411, -0.68956321477890015, 0.0317549891769886, new int[] { 9, 8, 6, 3, -1 }, new int[] { 11, 8, 2, 3, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0167079698294401, 0.0986552089452744, -0.1093738973140717, new int[] { 36, 1, 5, 6, -1 }, new int[] { 36, 3, 5, 2, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0111487796530128, -0.0638019666075706, 0.34605810046195978, new int[] { 4, 1, 5, 6, -1 }, new int[] { 4, 3, 5, 2, 3 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0027799250092357397, 0.2098781019449234, -0.13359400629997251, new int[] { 36, 9, 8, 1, -1 }, new int[] { 36, 9, 4, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.00024409759498666972, 0.0692380964756012, -0.31708741188049322, true, new int[] { 3, 3, 6, 2, -1 }, new int[] { 3, 3, 3, 2, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0297752991318703, -0.41800031065940862, 0.0322431214153767, new int[] { 39, 3, 4, 8, -1 }, new int[] { 39, 3, 2, 8, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0029159660916775465, 0.13949039578437811, -0.16484509408473971, new int[] { 2, 3, 4, 8, -1 }, new int[] { 4, 3, 2, 8, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-3.3617448934819549E-05, 0.0994415432214737, -0.0869354978203774, new int[] { 22, 7, 2, 2, -1 }, new int[] { 23, 7, 1, 1, 2 }, new int[] { 22, 8, 1, 1, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.1275593042373657, -0.5993226170539856, 0.0344392508268356, new int[] { 0, 5, 38, 6, -1 }, new int[] { 0, 5, 19, 3, 2 }, new int[] { 19, 8, 19, 3, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0119300801306963, 0.0343060009181499, -0.54623407125473022, true, new int[] { 43, 0, 2, 4, -1 }, new int[] { 43, 0, 1, 4, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(0.0128053296357393, 0.054770689457655, -0.33244410157203669, new int[] { 14, 6, 16, 4, -1 }, new int[] { 14, 6, 8, 2, 2 }, new int[] { 22, 8, 8, 2, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0110163297504187, -0.33880481123924261, 0.0193178597837687, true, new int[] { 43, 0, 2, 4, -1 }, new int[] { 43, 0, 1, 4, 2 } ) });
            nodes.Add(new[] { new HaarFeatureNode(-0.0015256899641826749, 0.19104599952697751, -0.1074023991823196, new int[] { 12, 4, 3, 4, -1 }, new int[] { 13, 4, 1, 4, 3 } ) });
            stage.Trees = nodes.ToArray(); stages.Add(stage);
            #endregion


            Stages = stages.ToArray();
         }
    }
}
