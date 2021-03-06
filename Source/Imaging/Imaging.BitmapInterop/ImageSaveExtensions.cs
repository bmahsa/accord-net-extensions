#region Licence and Terms
// Accord.NET Extensions Framework
// https://github.com/dajuric/accord-net-extensions
//
// Copyright © Darko Jurić, 2014 
// darko.juric2@gmail.com
//
//   This program is free software: you can redistribute it and/or modify
//   it under the terms of the GNU Lesser General Public License as published by
//   the Free Software Foundation, either version 3 of the License, or
//   (at your option) any later version.
//
//   This program is distributed in the hope that it will be useful,
//   but WITHOUT ANY WARRANTY; without even the implied warranty of
//   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//   GNU Lesser General Public License for more details.
// 
//   You should have received a copy of the GNU Lesser General Public License
//   along with this program.  If not, see <https://www.gnu.org/licenses/lgpl.txt>.
//
#endregion

namespace Accord.Extensions.Imaging
{
    /// <summary>
    /// Generic image save extensions.
    /// <para>An image is first converted to <see cref="System.Drawing.Bitmap"/> and then saved.</para>
    /// </summary>
    public static class ImageSaveExtensions
    {
        /// <summary>
        /// Save an image.
        /// </summary>
        /// <param name="image">Input image.</param>
        /// <param name="filename">File name</param>
        public static void Save<TColor>(this Image<TColor, byte> image, string filename)
            where TColor : IColor3
        {
            Save<TColor, byte>(image, filename);
        }

        /// <summary>
        /// Save an image. 
        /// </summary>
        /// <param name="image">Input image.</param>
        /// <param name="filename">File name</param>
        public static void Save(this Image<Gray, byte> image, string filename)
        {
            Save<Gray, byte>(image, filename);
        }

        private static void Save<TColor, TDepth>(this Image<TColor, TDepth> image, string filename)
            where TColor : IColor
            where TDepth : struct
        {
            image.ToBitmap().Save(filename); 
        }
    }
}
