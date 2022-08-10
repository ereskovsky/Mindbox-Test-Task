using System;
using System.Collections.Generic;
using System.Text;

namespace GeometryFabric
{
    public static class Settings
    {
        public static Dictionary<int, string> ReturnFigureList() 
        {
            return new Dictionary<int, string> {
                { 1, "RegularPolytop" }, 
                { 2, "Circle" }, 
                { 3, "Triangle" } 
            }; 
        } 
    }
}
