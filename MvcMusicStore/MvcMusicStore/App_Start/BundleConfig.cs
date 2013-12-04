using System;
using System.Web;
using System.Web.Optimization;


namespace MvcMusicStore
       {
           public class BundleConfig
            {
                public static void RegisterBundle(BundleCollection bundles)
                {
                    bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/jquery-migrate-{version}.js"));
                }
            }
        }

