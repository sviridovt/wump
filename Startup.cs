using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace WumpHunt
{
    class Startup
    {

        public static readonly String appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        //TODO add all needed global variables
        public Startup()
        {
        }

        public static void main()
        {
            //TODO: Add startup script 
            Splash splash = new Splash(); //Call to GUI Splash Screen, need the variables for declaring new screen 
        }

       /// <summary>
       /// Gets the game folder path, if AppData is inaccessible then  uses My Documents for game data.
       /// </summary>
       /// <returns>String of the game folder</returns>
        public String getGameFolder()
        {
            //TODO: Add some sort of import option 
            if (System.IO.Directory.Exists(appData + "/WumpHunt")){
                return appData + "/WumpHunt/"; 
            }
            else{
            try
            {
                System.IO.Directory.CreateDirectory(appData + "/WumpHunt");
                return appData + "/WumpHunt/";
            }
            catch (Exception gameFoldException)
            { 
                Console.WriteLine("Exception trying to create directory in AppData, going with MyDocuments folder"); 
                return Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            }
            }
        }
    }
    }



