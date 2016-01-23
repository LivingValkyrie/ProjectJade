using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivingValkyrie.TimeLine {

    /// <summary>
    /// Author: Matt Gipson
    /// Contact: Deadwynn@gmail.com
    /// Domain: www.livingvalkyrie.com
    /// 
    /// Description: Grid 
    /// </summary>
    public class Grid {
        #region Fields

        public bool isStatic;
        public int gridSize;
        public int offSet;

        #endregion

        public Grid(int gridSize, bool isStatic) {
            this.gridSize = gridSize;
            this.isStatic = isStatic;
        }

        /// <summary>
        /// draws the grid.
        /// </summary>
        public void OnDraw(Graphics canvasToDrawOn) {
            //get canvas specs
            float canvasWidth = canvasToDrawOn.DpiX;
            float canvasHeight = canvasToDrawOn.DpiY;

            //get line counts
            int horizontalGridLines = (int) (canvasHeight / gridSize);
            int verticalGridLines = (int) (canvasWidth / gridSize);

            //create pen
            Pen pen = new Pen(Color.Red);

            for (int i = 0; i < verticalGridLines; i++) {
             //canvasToDrawOn.DrawLine();
            }
            for (int j = 0; j < horizontalGridLines; j++) {}
        }

        /// <summary>
        /// Calculates zoom amount. updates gridSize to match zoom;
        /// </summary>
        public void OnZoom() {}

        /// <summary>
        /// Changes offset to match pan position.
        /// </summary>
        public void OnPan() {}

    }
}