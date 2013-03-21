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
  public static String status = "initilizing";
 //TODO add all needed global variables
 public Startup()
    {
      Splash splash = new Splash(); //Call to GUI Splash Screen, need the variables for declaring new screen  
    Sound sound = new Sound();
 }
                                                    
 public static void main()
{
//TODO: Add startup script 
                                                                                  
 }
                                                                    
 /// <summary>
/// Gets the game folder path, if AppData is inaccessible then  uses My Documents for game data.
/// </summary>
/// <returns>String of the game folder</returns>
public String getGameFolder()
{
//TODO: Add some sort of import option 
if (System.IO.Directory.Exists(appData + "/WumpHunt"))
{
return appData + "/WumpHunt/";
}
else
{
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
/// <summary>
/// Updates the game status 
/// </summary>
/// <param name="newStatus">New status</param>
/// <returns>whether the status was changed, if the status wasnt changed then 'newStatus' is same as the current status</returns>
public Boolean updateStatus(String newStatus)
{
if(status == newStatus){
return false;
}
else
{
status = newStatus;
return true; 
}
}
                                                                                                                                                                            
/// <summary>
/// Gets the current game state
/// </summary>
/// <returns>current game state</returns>
public static String getStatus()
{
return status;
}
          }
}



