﻿using LauncherBackend.Exceptions;
using LauncherBackend.Modells;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

// --------------------------------------------------
//              Launcher - FTPServer
//              Márton Bán (C) 2024
//  
//  This is an imitates the FTP Server and a Downlad
//  Manager class. Throw the service layer the GUI
//  will request the installation.
//
//  If we want to install an app 
//---------------------------------------------------

namespace LauncherBackend.Global
{
    public static class FileSystemService
    {
        public static void InstallGame(GameDataDTO game, string installationPath)
        {
            string ftpPath = FTP.GetRoot();
            if (CanInstall(game, installationPath)) {
                try {
                    System.IO.Compression.ZipFile.ExtractToDirectory(ftpPath + game.FTPFolderPath + game.FileName, installationPath + "/" + game.GameTitle);
                } catch (IOException) {
                    Console.WriteLine("Error FileSystemService: Game not able to install! \n");
                    Console.WriteLine("Probably invalid Path");
                }
            } else {
                throw new CannotInstallGameExeption("You can't install the game. \n" +
                    "Installation path is not exists OR the file is not exists in the FTP server");
            }
        }

        public static bool IsPathExist(string installationPath) {
            if (Directory.Exists(installationPath)) {
                return true;
            }
            else {
                return false;
            }
        }

        //-------------------------
        //    Helper Functions
        //-------------------------
        private static bool CanInstall(GameDataDTO game, string installationPath) {
            return FTP.IsThisFileExistInFTP(FTP.GetRoot() + game.FTPFolderPath + game.FileName)
                    && IsPathExist(installationPath);
        }
    }
}