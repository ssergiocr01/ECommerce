﻿using System.Web;
using System.Web.Optimization;

namespace ECommerce
{
    public class BundleConfig
    {
        // Para obtener más información sobre Bundles, visite http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información. De este modo, estará
            // preparado para la producción y podrá utilizar la herramienta de compilación disponible en http://modernizr.com para seleccionar solo las pruebas que necesite.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                     "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/admin-lte/css/AdminLTE.css",
                      "~/admin-lte/css/skins/skin-blue.css",
                      "~/admin-lte/bower_components/font-awesome/css/font-awesome.css",
                      "~/admin-lte/bower_components/Ionicons/css/ionicons.css",
                      "~/admin-lte/bower_components/DataTables/datatables.min.css"                      
                      ));

            bundles.Add(new ScriptBundle("~/admin-lte/js").Include(
                      "~/admin-lte/js/adminlte.js",
                      "~/admin-lte/bower_components/fastclick/fastclick.js",
                      "~/admin-lte/bower_components/bootstrap-datepicker/js/bootstrap-datepicker.js",
                      "~/admin-lte/bower_components/jquery-slimscroll/jquery.slimscroll.js",
                      "~/admin-lte/bower_components/DataTables/datatables.min.js"
             ));
        }
    }
}
