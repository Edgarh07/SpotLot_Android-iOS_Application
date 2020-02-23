﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace CSE455V2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MapViewPage : ContentPage
    {
        Position position = new Position(34.182821, -117.323526);
        MapSpan mapSpan;
        Map map;
        public MapViewPage()
        {
            InitializeComponent();

            mapSpan = new MapSpan(position, 0.01, 0.01);

            map = new Map(mapSpan)     // default can just be: Map map = new Map();
            {
                MapType = MapType.Hybrid   // can change between views
                //HasScrollEnabled = false
                //HasZoomEnabled = false
            };

            //double zoomLevel = 0.5;
            //double latlongDegrees = 360 / (Math.Pow(2, zoomLevel));
           // if (map.VisibleRegion != null)
           // {
              //  map.MoveToRegion(new MapSpan(map.VisibleRegion.Center, latlongDegrees, latlongDegrees));
           // }

            Content = map;

            //map.MoveToRegion(MapSpan.FromCenterAndRadius(position, Distance.FromMiles(1)));
           // Debug.WriteLine("$$$$$$$$The center is: " + mapSpan.Radius.Meters + "  $$$$$");

            Polygon lotF_Back = new Polygon
            {
                StrokeWidth = 8,
                StrokeColor = Color.FromHex("#03C04A"),
                FillColor = Color.FromHex("#8803C04A"),
                Geopath =
                {
                    new Position(34.186291, -117.327119),
                    new Position(34.185522, -117.326332),
                    new Position(34.185773, -117.325967),
                    new Position(34.185904, -117.326082),
                    new Position(34.186079, -117.325865),
                    new Position(34.186458, -117.326289),
                    new Position(34.186655, -117.326045),
                    new Position(34.186910, -117.326410)
                }
            };

            /*
            if("Parking Lot data for green")
            {
                "LotN".StrokeColor = Color.FromHex("#03C04A");
            }
            
            elseif("Parking Lot data for for red")
            {
                "LotN".StrokeColor = Color.FromHex("#f55542");
            }
            else 
            {
                "LotN".StrokeColor = Color.FromHex("#ffd733");
            }
            */

            Polygon lotA = new Polygon
            {
                StrokeWidth = 8,
                StrokeColor = Color.FromHex("#03C04A"),
                FillColor = Color.FromHex("#8803C04A"),
                Geopath =
                {
                    new Position(34.186495, -117.328797),
                    new Position(34.185785, -117.328000),
                    new Position(34.186302, -117.327356),
                    new Position(34.186828, -117.327976)
                }
            };

            /*
            if("Parking Lot data for green")
            {
                "LotN".StrokeColor = Color.FromHex("#03C04A");
            }
            
            elseif("Parking Lot data for for red")
            {
                "LotN".StrokeColor = Color.FromHex("#f55542");
            }
            else 
            {
                "LotN".StrokeColor = Color.FromHex("#ffd733");
            }
            */

            Polygon lotB = new Polygon
            {
                StrokeWidth = 8,
                StrokeColor = Color.FromHex("#03C04A"),
                FillColor = Color.FromHex("#8803C04A"),
                Geopath =
                {
                    new Position(34.183258, -117.328517),
                    new Position(34.182861, -117.329745),
                    new Position(34.182442, -117.329528),
                    new Position(34.182389, -117.329198),
                    new Position(34.182620, -117.328216)
                }
            };

            /*
            if("Parking Lot data for green")
            {
                "LotN".StrokeColor = Color.FromHex("#03C04A");
            }
            
            elseif("Parking Lot data for for red")
            {
                "LotN".StrokeColor = Color.FromHex("#f55542");
            }
            else 
            {
                "LotN".StrokeColor = Color.FromHex("#ffd733");
            }
            */

            Polygon lotB_Annex = new Polygon
            {
                StrokeWidth = 8,
                StrokeColor = Color.FromHex("#03C04A"),
                FillColor = Color.FromHex("#8803C04A"),
                Geopath =
                {
                    new Position(34.184195, -117.328776),
                    new Position(34.184148, -117.329227),
                    new Position(34.183831, -117.329017),
                    new Position(34.183665, -117.328757),
                    new Position(34.183438, -117.328291),
                    new Position(34.183806, -117.328160)
                }
            };

            /*
            if("Parking Lot data for green")
            {
                "LotN".StrokeColor = Color.FromHex("#03C04A");
            }
            
            elseif("Parking Lot data for for red")
            {
                "LotN".StrokeColor = Color.FromHex("#f55542");
            }
            else 
            {
                "LotN".StrokeColor = Color.FromHex("#ffd733");
            }
            */

            Polygon lotC = new Polygon
            {
                StrokeWidth = 8,
                StrokeColor = Color.FromHex("#03C04A"),
                FillColor = Color.FromHex("#8803C04A"),
                Geopath =
                {
                    new Position(34.182275, -117.327918),
                    new Position(34.181519, -117.328865),
                    new Position(34.179375, -117.327221),
                    new Position(34.180391, -117.325899)
                }
            };

            /*
            if("Parking Lot data for green")
            {
                "LotN".StrokeColor = Color.FromHex("#03C04A");
            }
            
            elseif("Parking Lot data for for red")
            {
                "LotN".StrokeColor = Color.FromHex("#f55542");
            }
            else 
            {
                "LotN".StrokeColor = Color.FromHex("#ffd733");
            }
            */

            Polygon lotD = new Polygon
            {
                StrokeWidth = 8,
                StrokeColor = Color.FromHex("#03C04A"),
                FillColor = Color.FromHex("#8803C04A"),
                Geopath =
                {
                    new Position(34.180105, -117.325223),
                    new Position(34.178490, -117.325837),
                    new Position(34.177722, -117.323699),
                    new Position(34.179042, -117.323146),
                    new Position(34.179093, -117.323401),
                    new Position(34.179708, -117.323307)
                }
            };

            /*
            if("Parking Lot data for green")
            {
                "LotN".StrokeColor = Color.FromHex("#03C04A");
            }
            
            elseif("Parking Lot data for for red")
            {
                "LotN".StrokeColor = Color.FromHex("#f55542");
            }
            else 
            {
                "LotN".StrokeColor = Color.FromHex("#ffd733");
            }
            */

            /*
            Polygon lotE = new Polygon
            {
                StrokeWidth = 8,
                StrokeColor = Color.FromHex("#03C04A"),
                FillColor = Color.FromHex("#8803C04A"),
                Geopath =
                {
                    new Position(34.180222, -117.321648),           // Parking Lot no longer exist
                    new Position(34.179137, -117.321264),
                    new Position(34.179457, -117.319872),
                    new Position(34.180575, -117.320288),
                    new Position(34.180484, -117.321527)
                }
            };

            */

            Polygon lotF_Front = new Polygon
            {
                StrokeWidth = 8,
                StrokeColor = Color.FromHex("#03C04A"),
                FillColor = Color.FromHex("#8803C04A"),
                Geopath =
                {
                    new Position(34.179355, -117.319829),
                    new Position(34.179033, -117.321226),
                    new Position(34.177662, -117.320708),
                    new Position(34.177915, -117.319514),
                    new Position(34.178552, -117.319734),
                    new Position(34.178678, -117.319595)
                }
            };

            /*
            if("Parking Lot data for green")
            {
                "LotN".StrokeColor = Color.FromHex("#03C04A");
            }
            
            elseif("Parking Lot data for for red")
            {
                "LotN".StrokeColor = Color.FromHex("#f55542");
            }
            else 
            {
                "LotN".StrokeColor = Color.FromHex("#ffd733");
            }
            */

            Polygon lotG = new Polygon
            {
                StrokeWidth = 8,
                StrokeColor = Color.FromHex("#03C04A"),
                FillColor = Color.FromHex("#8803C04A"),
                Geopath =
                {
                    new Position(34.179628, -117.319110),
                    new Position(34.179928, -117.317844),
                    new Position(34.180827, -117.318152),
                    new Position(34.180834, -117.319523)
                }
            };

            /*
            if("Parking Lot data for green")
            {
                "LotN".StrokeColor = Color.FromHex("#03C04A");
            }
            
            elseif("Parking Lot data for for red")
            {
                "LotN".StrokeColor = Color.FromHex("#f55542");
            }
            else 
            {
                "LotN".StrokeColor = Color.FromHex("#ffd733");
            }
            */

            Polygon lotH = new Polygon
            {
                StrokeWidth = 8,
                StrokeColor = Color.FromHex("#03C04A"),
                FillColor = Color.FromHex("#8803C04A"),
                Geopath =
                {
                    new Position(34.179533, -117.319089),
                    new Position(34.178330, -117.318536),
                    new Position(34.178836, -117.317479),
                    new Position(34.179810, -117.317820)
                }
            };

            /*
            if("Parking Lot data for green")
            {
                "LotN".StrokeColor = Color.FromHex("#03C04A");
            }
            
            elseif("Parking Lot data for for red")
            {
                "LotN".StrokeColor = Color.FromHex("#f55542");
            }
            else 
            {
                "LotN".StrokeColor = Color.FromHex("#ffd733");
            }
            */

            Polygon lot_EPS = new Polygon
            {
                StrokeWidth = 8,
                StrokeColor = Color.FromHex("#03C04A"),
                FillColor = Color.FromHex("#8803C04A"),
                Geopath =
                {
                    new Position(34.184554, -117.320294),
                    new Position(34.183789, -117.320911),
                    new Position(34.183472, -117.320176),
                    new Position(34.184189, -117.319618)
                }
            };

            /*
            if("Parking Lot data for green")
            {
                "LotN".StrokeColor = Color.FromHex("#03C04A");
            }
            
            elseif("Parking Lot data for for red")
            {
                "LotN".StrokeColor = Color.FromHex("#f55542");
            }
            else 
            {
                "LotN".StrokeColor = Color.FromHex("#ffd733");
            }
            */

            Polygon lotN = new Polygon
            {
                StrokeWidth = 8,
                StrokeColor = Color.FromHex("#03C04A"),
                FillColor = Color.FromHex("#8803C04A"),
                Geopath =
                {
                    new Position(34.184839, -117.320503),
                    new Position(34.183932, -117.321190),
                    new Position(34.184271, -117.321850),
                    new Position(34.183738, -117.322287),
                    new Position(34.184286, -117.323234),
                    new Position(34.184643, -117.322952),
                    new Position(34.185178, -117.323931),
                    new Position(34.185635, -117.323606),
                    new Position(34.185586, -117.323456),
                    new Position(34.185843, -117.323204),
                    new Position(34.185426, -117.322359),
                    new Position(34.185557, -117.322230),
                    new Position(34.185071, -117.321259),
                    new Position(34.185184, -117.321146)
                }
            };

            /*
            if("Parking Lot data for green")
            {
                "LotN".StrokeColor = Color.FromHex("#03C04A");
            }
            
            elseif("Parking Lot data for for red")
            {
                "LotN".StrokeColor = Color.FromHex("#f55542");
            }
            else 
            {
                "LotN".StrokeColor = Color.FromHex("#ffd733");
            }
            */

            map.MapElements.Add(lotF_Back);
            map.MapElements.Add(lotA);
            map.MapElements.Add(lotB_Annex);
            map.MapElements.Add(lotB);
            map.MapElements.Add(lotC);
            map.MapElements.Add(lotD);
            //map.MapElements.Add(lotE);
            map.MapElements.Add(lotF_Front);
            map.MapElements.Add(lotG);
            map.MapElements.Add(lotH);
            map.MapElements.Add(lot_EPS);
            map.MapElements.Add(lotN);
        }

    }
}