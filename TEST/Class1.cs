﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST
{
    public class TEST
    {

        static void Main(string[] args)
        {
            double[] arr;
            arr = new double[5] { 2077, 2077, 2078, 2083, 2082 };
            List<double> dd = new List<double>() { 5.853333, 5.516666, 5.513333, 5.533333, 5.58};
            dd = new List<double>() { 329.79333333333333333333333333, 333.25666666666666666666666667, 350.04333333333333333333333333, 346.66666666666666666666666667, 346.38, 343.48666666666666666666666667, 336.33666666666666666666666667, 339.45, 343.82333333333333333333333333, 343.39, 347.45, 345.41, 343.06333333333333333333333333, 346.32666666666666666666666667, 345.92333333333333333333333333, 340.93333333333333333333333333, 356.83, 359.87666666666666666666666667, 359.12666666666666666666666667, 366.01, 366.30, 372.98666666666666666666666667, 382.59333333333333333333333333, 399.20666666666666666666666667, 406.01, 396.05333333333333333333333333, 403.01, 411.86666666666666666666666667, 406.47, 405.20666666666666666666666667, 404.55, 404.37666666666666666666666667, 394.95666666666666666666666667, 394.13333333333333333333333333, 400.47333333333333333333333333, 395.07, 396.76, 403.89333333333333333333333333, 400.97333333333333333333333333, 402.88, 401.37666666666666666666666667, 393.30, 391.03333333333333333333333333, 391.01, 390.83666666666666666666666667, 390.87666666666666666666666667, 391.60333333333333333333333333, 400.54666666666666666666666667, 401.14333333333333333333333333, 404.86333333333333333333333333, 403.66, 406.22666666666666666666666667, 398.61333333333333333333333333, 393.59333333333333333333333333, 391.63666666666666666666666667, 390.85666666666666666666666667, 392.45666666666666666666666667, 391.94, 389.79333333333333333333333333, 386.47333333333333333333333333, 385.32, 392.08666666666666666666666667, 390.75666666666666666666666667, 394.51333333333333333333333333, 394.83666666666666666666666667, 391.07333333333333333333333333, 392.96333333333333333333333333, 395.12333333333333333333333333, 391.87333333333333333333333333, 390.00666666666666666666666667, 389.23333333333333333333333333, 382.14, 383.17333333333333333333333333, 382.61, 383.36333333333333333333333333, 377.94333333333333333333333333, 374.07666666666666666666666667, 378.97, 379.53333333333333333333333333, 371.02, 371.03666666666666666666666667, 368.83333333333333333333333333, 370.95, 378.17333333333333333333333333, 385.46, 392.33333333333333333333333333, 390.80333333333333333333333333, 388.62666666666666666666666667, 389.32, 386.61666666666666666666666667, 390.73333333333333333333333333, 391.34666666666666666666666667, 390.20333333333333333333333333, 388.06333333333333333333333333, 390.29666666666666666666666667, 397.57666666666666666666666667, 401.09666666666666666666666667, 402.90666666666666666666666667, 404.04, 406.90, 404.47666666666666666666666667, 402.33666666666666666666666667, 402.69666666666666666666666667, 402.55, 402.22666666666666666666666667, 407.65333333333333333333333333, 404.95333333333333333333333333, 407.37666666666666666666666667, 402.99666666666666666666666667, 398.07666666666666666666666667, 399.94666666666666666666666667, 399.95, 397.36666666666666666666666667, 396.11, 395.26333333333333333333333333, 394.47666666666666666666666667, 398.13333333333333333333333333, 402.68, 403.62, 406.98666666666666666666666667, 414.00666666666666666666666667, 408.30666666666666666666666667, 410.03333333333333333333333333, 410.17, 405.85666666666666666666666667, 413.33, 417.06666666666666666666666667, 428.24666666666666666666666667, 430.33666666666666666666666667, 420.91333333333333333333333333, 423.17666666666666666666666667, 423.37, 419.39666666666666666666666667, 417.47, 418.51333333333333333333333333, 415.27666666666666666666666667, 417.96, 415.91, 409.51333333333333333333333333, 411.57666666666666666666666667, 416.19, 414.32333333333333333333333333, 416.46666666666666666666666667, 424.35, 427.13666666666666666666666667, 443.61666666666666666666666667, 443.54333333333333333333333333, 448.97666666666666666666666667, 445.48333333333333333333333333, 445.53666666666666666666666667, 441.00333333333333333333333333, 442.15666666666666666666666667, 440.56, 435.94333333333333333333333333, 443.99, 451.13, 452.87666666666666666666666667, 453.13, 450.35, 446.67, 443.89, 439.90, 442.75333333333333333333333333, 442.64666666666666666666666667, 439.50666666666666666666666667, 439.15, 442.99333333333333333333333333, 441.82333333333333333333333333, 444.48333333333333333333333333, 447.29, 445.56666666666666666666666667, 443.53, 447.59333333333333333333333333, 457.75333333333333333333333333, 458.45333333333333333333333333, 462.66, 462.13333333333333333333333333, 461.98666666666666666666666667, 457.47666666666666666666666667, 453.66666666666666666666666667, 455.04666666666666666666666667, 454.64666666666666666666666667, 455.00666666666666666666666667, 457.46666666666666666666666667, 466.17333333333333333333333333, 468.48666666666666666666666667, 470.65666666666666666666666667, 473.75, 473.72333333333333333333333333, 472.52333333333333333333333333, 476.45, 478.72333333333333333333333333, 483.14666666666666666666666667, 490.77333333333333333333333333, 501.17666666666666666666666667, 500.39, 497.71, 495.06333333333333333333333333, 486.59, 484.36666666666666666666666667, 489.05, 491.84333333333333333333333333, 492.84333333333333333333333333, 497.44, 498.76, 500.63666666666666666666666667, 497.78666666666666666666666667, 491.88, 496.47, 505.91333333333333333333333333, 505.88333333333333333333333333, 503.53666666666666666666666667, 513.75666666666666666666666667, 517.89666666666666666666666667, 528.65, 515.73666666666666666666666667, 507.58333333333333333333333333, 530.43666666666666666666666667, 535.17666666666666666666666667, 534.43333333333333333333333333, 529.52, 525.84333333333333333333333333, 530.80, 531.19333333333333333333333333, 532.83666666666666666666666667, 520.84666666666666666666666667, 518.52333333333333333333333333, 523.70333333333333333333333333, 524.94333333333333333333333333, 527.09333333333333333333333333, 533.57333333333333333333333333, 545.42, 544.96, 547.04333333333333333333333333, 559.23333333333333333333333333, 563.30333333333333333333333333, 575.86, 575.21666666666666666666666667, 574.75, 576.59333333333333333333333333, 566.72333333333333333333333333, 570.88, 571.40666666666666666666666667, 567.90, 571.30333333333333333333333333, 583.11, 590.65666666666666666666666667, 595.04666666666666666666666667, 601.71666666666666666666666667, 602.16333333333333333333333333, 605.09333333333333333333333333, 595.94, 591.45, 597.41, 597.55666666666666666666666667, 601.16333333333333333333333333, 604.41333333333333333333333333, 602.51, 614.53333333333333333333333333, 616.98333333333333333333333333, 608.57666666666666666666666667, 604.01, 601.55, 591.08, 578.31666666666666666666666667, 584.94, 581.48333333333333333333333333, 577.88, 585.19, 597.51333333333333333333333333, 594.62666666666666666666666667, 592.03, 590.96333333333333333333333333, 584.43333333333333333333333333, 585.28666666666666666666666667, 592.75, 601.02, 610.53666666666666666666666667, 620.50, 620.17666666666666666666666667, 612.60666666666666666666666667, 613.65333333333333333333333333, 621.73, 625.54666666666666666666666667, 622.13333333333333333333333333, 624.79, 620.85666666666666666666666667, 615.00666666666666666666666667, 620.77, 624.73, 633.74, 638.64666666666666666666666667, 630.96666666666666666666666667, 642.89666666666666666666666667, 643.89333333333333333333333333, 642.83333333333333333333333333, 638.94666666666666666666666667, 635.37333333333333333333333333, 635.06333333333333333333333333, 628.30666666666666666666666667, 637.06333333333333333333333333, 639.35666666666666666666666667, 637.90333333333333333333333333, 638.82666666666666666666666667, 635.38, 637.67333333333333333333333333, 637.06666666666666666666666667, 640.21, 638.94666666666666666666666667, 635.93333333333333333333333333, 630.78333333333333333333333333, 624.92666666666666666666666667, 616.42666666666666666666666667, 618.24, 626.46, 633.78333333333333333333333333, 636.24666666666666666666666667, 634.86666666666666666666666667, 644.06333333333333333333333333, 645.30666666666666666666666667, 644.01333333333333333333333333, 644.85, 646.41333333333333333333333333, 655.20666666666666666666666667, 658.18666666666666666666666667, 658.62, 668.58, 672.59, 683.77666666666666666666666667, 695.57666666666666666666666667, 706.20, 704.72, 716.07333333333333333333333333, 726.76, 721.74333333333333333333333333, 724.92333333333333333333333333, 748.51333333333333333333333333, 745.39333333333333333333333333, 743.41, 735.88, 733.61666666666666666666666667, 782.20333333333333333333333333, 827.29, 812.67, 801.7833333333333333333333333, 808.6566666666666666666666667, 811.1966666666666666666666667, 826.04, 843.3666666666666666666666667, 835.44, 841.3133333333333333333333333, 841.7366666666666666666666667, 871.1566666666666666666666667, 888.8466666666666666666666667, 881.6233333333333333333333333, 887.4866666666666666666666667, 921.1833333333333333333333333, 896.27, 875.7433333333333333333333333, 876.2066666666666666666666667, 854.7333333333333333333333333, 823.85, 817.7433333333333333333333333, 807.0866666666666666666666667, 832.1633333333333333333333333, 829.8566666666666666666666667, 821.52, 810.94, 821.4966666666666666666666667, 823.7733333333333333333333333, 814.28, 801.16, 809.3233333333333333333333333, 837.21, 846.1166666666666666666666667, 860.5966666666666666666666667, 861.82, 850.6133333333333333333333333, 861.50, 863.99, 881.1866666666666666666666667, 883.0333333333333333333333333, 883.7933333333333333333333333, 892.7033333333333333333333333, 884.56, 866.62, 916.1333333333333333333333333, 911.1033333333333333333333333, 909.3766666666666666666666667, 923.99, 951.23, 955.7633333333333333333333333, 970.2766666666666666666666667, 1004.1133333333333333333333333, 1014.9733333333333333333333333, 1007.15, 1014.6066666666666666666666667, 1019.8433333333333333333333333, 1004.8366666666666666666666667, 974.3533333333333333333333333, 975.0666666666666666666666667, 971.09, 995.3133333333333333333333333, 1002.79, 992.3633333333333333333333333, 992.8033333333333333333333333, 1002.6866666666666666666666667, 967.5333333333333333333333333, 959.6466666666666666666666667, 984.5333333333333333333333333, 983.1966666666666666666666667, 958.3766666666666666666666667, 930.19, 920.90, 898.04, 907.5733333333333333333333333, 879.2566666666666666666666667, 902.2233333333333333333333333, 920.8833333333333333333333333, 929.2566666666666666666666667, 956.1433333333333333333333333, 964.69, 962.61, 961.66, 943.32, 956.9266666666666666666666667, 954.28, 939.0133333333333333333333333, 926.7033333333333333333333333, 924.06, 931.9766666666666666666666667, 943.2966666666666666666666667, 940.7433333333333333333333333, 925.43, 935.7166666666666666666666667, 961.2666666666666666666666667, 962.7566666666666666666666667, 971.6333333333333333333333333, 967.5866666666666666666666667, 964.2333333333333333333333333, 947.0833333333333333333333333, 921.67, 921.0933333333333333333333333, 926.0933333333333333333333333, 886.1733333333333333333333333, 885.64, 887.64, 882.6566666666666666666666667, 880.38, 896.7733333333333333333333333, 904.3366666666666666666666667, 914.3166666666666666666666667, 916.1066666666666666666666667, 902.8233333333333333333333333, 893.8433333333333333333333333, 883.0966666666666666666666667, 869.10, 850.9266666666666666666666667, 873.3733333333333333333333333, 875.3733333333333333333333333, 872.6566666666666666666666667, 890.1133333333333333333333333, 892.93, 881.5233333333333333333333333, 864.25, 858.19, 865.88, 861.8933333333333333333333333, 892.6133333333333333333333333, 915.88, 911.1833333333333333333333333, 922.3766666666666666666666667, 933.5066666666666666666666667, 956.04, 960.8166666666666666666666667, 954.7966666666666666666666667, 944.5266666666666666666666667, 952.4833333333333333333333333, 955.26, 955.1266666666666666666666667, 942.8666666666666666666666667, 930.34, 930.42, 951.1066666666666666666666667, 953.55, 942.20, 966.50, 966.4466666666666666666666667, 1001.6766666666666666666666667, 1019.5933333333333333333333333, 1021.7666666666666666666666667, 1015.82, 1007.8566666666666666666666667, 1005.9033333333333333333333333, 1029.42, 1027.4033333333333333333333333, 1017.39, 1016.38, 979.48, 996.2966666666666666666666667, 1003.8866666666666666666666667, 1001.8333333333333333333333333, 1010.0266666666666666666666667, 994.0866666666666666666666667, 960.0633333333333333333333333, 932.14, 952.62, 941.1933333333333333333333333, 914.3933333333333333333333333, 909.79, 926.5933333333333333333333333, 935.61, 953.8866666666666666666666667, 951.35, 941.1733333333333333333333333, 963.7966666666666666666666667, 977.9033333333333333333333333, 993.4433333333333333333333333, 978.13, 972.1133333333333333333333333, 972.54, 970.0833333333333333333333333, 960.8566666666666666666666667, 972.6133333333333333333333333, 978.01, 970.4033333333333333333333333, 969.4366666666666666666666667, 950.60, 952.5366666666666666666666667, 944.76, 918.2333333333333333333333333, 896.4366666666666666666666667, 882.13, 894.2166666666666666666666667, 891.2266666666666666666666667, 902.7433333333333333333333333, 904.37, 889.52, 892.8566666666666666666666667, 875.8833333333333333333333333, 855.7766666666666666666666667, 839.9633333333333333333333333, 838.2366666666666666666666667, 874.4633333333333333333333333, 877.53, 881.63, 869.14, 894.7033333333333333333333333, 898.13, 899.8866666666666666666666667, 897.4966666666666666666666667, 871.0466666666666666666666667, 870.7233333333333333333333333, 882.81, 870.2866666666666666666666667, 849.82, 855.6866666666666666666666667, 848.7866666666666666666666667, 848.6166666666666666666666667, 831.9633333333333333333333333, 829.6866666666666666666666667, 842.22, 849.2933333333333333333333333, 868.3333333333333333333333333, 891.73, 893.8733333333333333333333333, 913.15, 917.4233333333333333333333333, 947.4666666666666666666666667, 949.72, 956.5166666666666666666666667, 912.2966666666666666666666667, 911.36, 889.9833333333333333333333333, 852.0133333333333333333333333, 873.47, 875.6133333333333333333333333, 878.9133333333333333333333333, 873.2733333333333333333333333, 852.97, 870.4533333333333333333333333, 907.5566666666666666666666667, 856.4666666666666666666666667, 835.61, 811.0066666666666666666666667, 805.7833333333333333333333333, 721.42666666666666666666666667, 689.78333333333333333333333333, 714.34333333333333333333333333, 743.23666666666666666666666667, 779.13333333333333333333333333, 760.84666666666666666666666667, 743.69666666666666666666666667, 745.53666666666666666666666667, 750.76333333333333333333333333, 740.68666666666666666666666667, 720.98, 740.02666666666666666666666667, 733.36333333333333333333333333, 735.66, 737.08333333333333333333333333, 745.33333333333333333333333333, 739.44, 739.69333333333333333333333333, 740.46333333333333333333333333, 735.10666666666666666666666667, 728.02, 721.86, 728.75666666666666666666666667, 729.85, 739.66666666666666666666666667, 785.74333333333333333333333333, 789.53333333333333333333333333, 798.7266666666666666666666667, 781.73, 774.37666666666666666666666667, 760.77, 765.16333333333333333333333333, 771.89333333333333333333333333, 788.31, 780.99666666666666666666666667, 775.83333333333333333333333333, 774.65666666666666666666666667, 762.90, 755.27, 745.77, 743.94, 739.93, 737.91666666666666666666666667, 742.35666666666666666666666667, 767.43, 789.94666666666666666666666667, 777.62333333333333333333333333, 786.24333333333333333333333333, 796.5933333333333333333333333, 795.4966666666666666666666667, 810.4633333333333333333333333, 812.1833333333333333333333333, 830.1966666666666666666666667, 823.3433333333333333333333333, 856.13, 867.62, 868.46, 893.0666666666666666666666667, 904.83, 884.6266666666666666666666667, 876.6566666666666666666666667, 882.7533333333333333333333333, 891.5266666666666666666666667, 894.74, 895.39, 891.53, 902.0833333333333333333333333, 911.1433333333333333333333333, 942.13, 944.8333333333333333333333333, 960.39, 968.35, 954.9966666666666666666666667, 970.9233333333333333333333333, 962.6266666666666666666666667, 950.92, 948.60, 950.78, 968.0166666666666666666666667, 962.3666666666666666666666667, 975.6766666666666666666666667, 988.8066666666666666666666667, 1027.96, 1031.14, 1026.45, 1012.12, 987.0333333333333333333333333, 970.77, 993.30, 983.0466666666666666666666667, 990.0766666666666666666666667, 1016.60, 1020.5266666666666666666666667, 1054.9333333333333333333333333, 1046.3033333333333333333333333, 1042.1833333333333333333333333, 1033.28, 1042.2066666666666666666666667, 1022.3433333333333333333333333, 1016.94, 1033.3066666666666666666666667, 1055.6066666666666666666666667, 1118.3666666666666666666666667, 1129.2433333333333333333333333, 1115.48, 1108.5466666666666666666666667, 1127.2933333333333333333333333, 1181.9866666666666666666666667, 1185.9866666666666666666666667, 1231.0433333333333333333333333, 1217.2733333333333333333333333, 1198.2366666666666666666666667, 1202.1766666666666666666666667, 1222.19, 1243.0733333333333333333333333, 1242.22, 1247.3066666666666666666666667, 1254.0466666666666666666666667, 1274.55, 1274.8433333333333333333333333, 1258.0033333333333333333333333, 1246.4866666666666666666666667, 1270.4766666666666666666666667, 1279.7166666666666666666666667, 1195.6133333333333333333333333, 1170.70, 1159.6766666666666666666666667, 1129.9166666666666666666666667, 1180.2433333333333333333333333, 1175.5666666666666666666666667, 1166.7533333333333333333333333, 1207.8433333333333333333333333, 1214.2766666666666666666666667, 1197.57, 1163.0633333333333333333333333, 1173.2833333333333333333333333, 1169.3366666666666666666666667, 1137.2066666666666666666666667, 1151.74, 1149.9666666666666666666666667, 1168.8433333333333333333333333, 1194.5533333333333333333333333, 1189.6366666666666666666666667, 1174.9133333333333333333333333, 1173.15, 1155.2166666666666666666666667, 1149.4466666666666666666666667, 1135.8433333333333333333333333, 1136.8533333333333333333333333, 1186.54, 1188.5133333333333333333333333, 1192.0966666666666666666666667, 1204.91, 1200.9166666666666666666666667, 1201.0666666666666666666666667, 1229.3566666666666666666666667, 1267.1166666666666666666666667, 1281.5333333333333333333333333, 1297.07, 1291.51, 1286.2466666666666666666666667, 1305.59, 1309.39, 1366.50, 1365.1533333333333333333333333, 1326.7533333333333333333333333, 1308.1266666666666666666666667, 1327.30, 1314.1933333333333333333333333, 1303.1433333333333333333333333, 1310.86, 1312.4466666666666666666666667, 1314.55, 1294.35, 1294.42, 1287.36, 1268.38, 1273.50, 1276.0833333333333333333333333, 1271.4566666666666666666666667, 1265.7566666666666666666666667, 1275.8233333333333333333333333, 1286.5233333333333333333333333, 1297.43, 1303.94, 1297.84, 1282.86, 1269.9466666666666666666666667, 1259.6066666666666666666666667, 1254.7866666666666666666666667, 1263.4966666666666666666666667, 1289.7733333333333333333333333, 1287.9866666666666666666666667, 1350.7766666666666666666666667, 1357.5133333333333333333333333, 1389.5133333333333333333333333, 1388.08, 1408.58, 1410.25, 1421.2133333333333333333333333, 1423.53, 1460.6433333333333333333333333, 1496.4333333333333333333333333, 1476.8333333333333333333333333, 1486.0766666666666666666666667, 1468.78, 1478.9333333333333333333333333, 1517.64, 1517.14, 1519.8333333333333333333333333, 1504.32, 1520.2733333333333333333333333, 1520.6833333333333333333333333, 1518.6533333333333333333333333, 1500.8766666666666666666666667, 1442.32, 1457.97, 1461.6233333333333333333333333, 1460.5333333333333333333333333, 1518.6333333333333333333333333, 1525.6733333333333333333333333, 1540.7833333333333333333333333, 1528.64, 1568.2733333333333333333333333, 1569.0966666666666666666666667, 1558.6933333333333333333333333, 1561.8066666666666666666666667, 1539.7833333333333333333333333, 1555.3766666666666666666666667, 1531.5966666666666666666666667, 1525.9566666666666666666666667, 1558.7766666666666666666666667, 1572.5266666666666666666666667, 1604.8766666666666666666666667, 1562.4733333333333333333333333, 1571.9133333333333333333333333, 1571.06, 1559.7066666666666666666666667, 1562.3033333333333333333333333, 1550.6166666666666666666666667, 1537.8733333333333333333333333, 1552.7166666666666666666666667, 1567.5033333333333333333333333, 1587.8833333333333333333333333, 1578.74, 1578.03, 1578.1233333333333333333333333, 1599.3633333333333333333333333, 1598.3066666666666666666666667, 1592.9333333333333333333333333, 1597.8466666666666666666666667, 1609.0266666666666666666666667, 1599.21, 1603.6433333333333333333333333, 1625.24, 1640.64, 1634.71, 1633.9766666666666666666666667, 1643.73, 1644.9966666666666666666666667, 1639.6966666666666666666666667, 1600.64, 1576.70, 1583.84, 1586.9833333333333333333333333, 1572.6833333333333333333333333, 1512.1033333333333333333333333, 1508.0466666666666666666666667, 1495.5533333333333333333333333, 1502.4133333333333333333333333, 1503.1766666666666666666666667, 1546.6733333333333333333333333, 1549.8066666666666666666666667, 1548.24, 1548.06, 1521.3133333333333333333333333, 1545.64, 1532.2333333333333333333333333, 1552.17, 1558.3733333333333333333333333, 1543.24, 1532.0666666666666666666666667, 1532.34, 1531.9733333333333333333333333, 1513.4433333333333333333333333, 1510.6966666666666666666666667, 1549.3066666666666666666666667, 1579.0733333333333333333333333, 1576.81, 1506.9933333333333333333333333, 1450.3233333333333333333333333, 1438.71, 1454.7966666666666666666666667, 1451.4266666666666666666666667, 1466.9033333333333333333333333, 1481.1366666666666666666666667 };
            //EMAResult du= ;
            var result = EMA(dd, 3);
            Console.WriteLine("{0}个result的值", result.Values.Count);

            for (int i = 0; i < result.Values.Count; i++)
            {
                Console.WriteLine("第{0}的ema={1}", i, result.Values[i]);
            }
            Console.WriteLine("emaR={0}", result.EmaR);
        }
        /// <summary>
        /// Contains calculation results for EMA indicator
        /// </summary>
        public class EMAResult
        {
            public List<double> Values { get; set; }
            public int StartIndexOffset { get; set; }
            public double EmaR { get; set; }

        }

        //-------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Calculates Exponential Moving Average (EMA) indicator
        /// </summary>
        /// <param name="input">Input signal</param>
        /// <param name="period">Number of periods</param>
        /// <returns>Object containing operation results</returns>
        public static EMAResult EMA(IEnumerable<double> input, int period)
        {
            var returnValues = new List<double>();

            double multiplier = (2.0 / (period + 1));
            //double initialSMA = input.Take(period).Average();

            //returnValues.Add(initialSMA);

            var copyInputValues = input.ToList();

            int j = 0;
            for (int i = copyInputValues.Count - period; i < copyInputValues.Count; i++)
            {
                if (j < 1)
                {
                    var resultValue = copyInputValues[i];
                    returnValues.Add(resultValue);
                }
                else
                {
                    var resultValue = (copyInputValues[i] * multiplier) + (1 - multiplier) * returnValues.Last();
                    returnValues.Add(resultValue);
                }
                j++;


            }

            var result = new EMAResult()
            {
                EmaR = returnValues.Last(),
                Values = returnValues,
                StartIndexOffset = period - 1
            };

            return result;
        }




    }
}