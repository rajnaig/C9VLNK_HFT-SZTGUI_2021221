﻿using C9VLNK_HFT_20211221.WpfClient.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C9VLNK_HFT_20211221.WpfClient.Services
{
    public class AlbumCreatorViaWindow : IAlbumCreatorService
    {
        public void CreateAlbum()
        {
            new AlbumCreatorWindow().ShowDialog();
        }
    }
}
