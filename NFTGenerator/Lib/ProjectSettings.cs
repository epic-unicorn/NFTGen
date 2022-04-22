﻿using System;
using System.ComponentModel;
using System.Drawing;

namespace NFTGenerator.Lib
{
    public enum ResampleAlgorithmEnum : byte { NearestNeighbor = 1, Bilinear = 2, BicubicSmoother = 3, BicubicSharper = 4 }
    public class ProjectSettings : ICloneable
    {
        public ProjectSettings()
        {
            OutputDirectory = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "NFTGenerator");
            OutputSize = new Size(500, 500);
            ResizeAlgorithm = ResampleAlgorithmEnum.NearestNeighbor; //nearest neighbor (hard edges)
            TokenMetaDescription = "Generated by NFT Generator";
            TokenImageBaseAddress = "ipfs://";
        }

        [Description("Description which every token will have in their meta data file."),
            DisplayName("Token Meta Description"),
            Category("Output")]        
        public string TokenMetaDescription { get; set; }

        [Description("Base url for each Token image location."),
            DisplayName("Token Image Base Address"),
            Category("Output")]
        public string TokenImageBaseAddress { get; set; }

        [Description("Path to output directory where images will be generated"),
            DisplayName("Output Folder"),
            Category("Output")]
        [EditorAttribute(typeof(System.Windows.Forms.Design.FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
        public string OutputDirectory { get; set; }

        [Description("Specifies whether project folder will be created in output directory"),
            DisplayName("Folderize Project"),
            Category("Output")]
        public bool CreateProjectFolderInOutputDirectory { get; set; }

        public string GetOutputPath(Project proj)
        {
            var pth = System.IO.Path.Combine(proj.Settings.OutputDirectory);
            if (proj.Settings.CreateProjectFolderInOutputDirectory)
            {
                pth = System.IO.Path.Combine(proj.Settings.OutputDirectory, proj.ProjectName);
            }
            return pth;
        }

        [Description("Size of output images in pixels"),
            DisplayName("Image Size"),
            Category("Output")]
        public Size OutputSize { get; set; }

        private bool predicatableShuffle = false;
        [Description("Determines that shuffle should produce same output every time. Uses ShuffleSeed number to produce this. If it is false (default) then system timer is used and every time shuffle is different."),
         DisplayName("Shuffle Predictable"),
         Category("Output")]
        public bool PredictableShuffle { get
            {
                return predicatableShuffle;
            }
            set
            {
                predicatableShuffle = value;
                if (predicatableShuffle && ShuffleSeed == 0)
                {
                    Random rnd = new Random();
                    ShuffleSeed = rnd.Next(1, 9999);
                }
            }

        }

        [Description("Determines seed for shuffling new image collection. Used for predictible shuffle. If value is >0 then shuffle order will be same every time. If value is 0 (default) then timer value is used (every time order is different and unpredictable)."),
            DisplayName("Shuffle Seed"),
            Category("Output")]
        public int ShuffleSeed { get; set; }

        [Description("Resize algorithm applied when resizing images to output size. Default is Point which is Nearest Neighbor. More can be found here https://legacy.imagemagick.org/Usage/filter/"),
            DisplayName("Resample Algorithm"),
            Category("Output")]
        public ResampleAlgorithmEnum ResizeAlgorithm { get; set; }

        public ImageMagick.FilterType GetMagickResizeAlgorithm()
        {
            switch (ResizeAlgorithm)
            {
                case ResampleAlgorithmEnum.NearestNeighbor:
                    return ImageMagick.FilterType.Point;
                case ResampleAlgorithmEnum.Bilinear:
                    return ImageMagick.FilterType.Triangle;
                case ResampleAlgorithmEnum.BicubicSmoother:
                    return ImageMagick.FilterType.Cubic;
                case ResampleAlgorithmEnum.BicubicSharper:
                    return ImageMagick.FilterType.Hermite;
            }
            return ImageMagick.FilterType.SincFast;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
