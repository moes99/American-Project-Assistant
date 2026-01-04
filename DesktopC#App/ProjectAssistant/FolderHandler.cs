using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace ProjectAssistant
{
    internal class FolderHandler
    {
        public static bool createFolderFromTreeView(string basePath, TreeView treeView)
        {
            try
            {
                TreeNode rootNode = treeView.Nodes[0];
                createFoldersRecursively(basePath, rootNode);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating folders: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private static void createFoldersRecursively(string currentPath, TreeNode node)
        {
            foreach (TreeNode childNode in node.Nodes)
            {
                string newFolderPath = Path.Combine(currentPath, childNode.Text);
                if (!Directory.Exists(newFolderPath))
                {
                    Directory.CreateDirectory(newFolderPath);
                }
                createFoldersRecursively(newFolderPath, childNode);
            }
        }

        public static List<string> getFileNamesInDirectory(string directory)
        {
            List<string> fileNames = new List<string>();
            try
            {
                if (Directory.Exists(directory))
                {
                    string[] files = Directory.GetFiles(directory);
                    foreach (string file in files)
                    {
                        fileNames.Add(Path.GetFileName(file));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving file names: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return fileNames;
        }

        public static List<string> getAllDirectoriesHavingFilesOnly(string rootDirectory)
        {
            List<string> result = new List<string>();

            try
            {
                if (!Directory.Exists(rootDirectory))
                {
                    MessageBox.Show("The specified root directory does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return result;
                }
                findDirectoriesWithFilesRecursice(rootDirectory, result);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error retrieving directories: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            return result;
        }

        private static void findDirectoriesWithFilesRecursice(string directory, List<string> result)
        {
            try
            {
                if(Directory.GetFiles(directory).Length > 0)
                {
                    result.Add(directory);
                }

                if(Directory.GetDirectories(directory).Length > 0)
                {
                    string[] subDirectories = Directory.GetDirectories(directory);
                    foreach (string subDir in subDirectories)
                    {
                        findDirectoriesWithFilesRecursice(subDir, result);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error retrieving directories: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        public static bool copyFileToDirectory(string sourceFilePath, string destinationDirectory)
        {
            try
            {
                if (!File.Exists(sourceFilePath))
                {
                    MessageBox.Show("Source file does not exist. " + sourceFilePath , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (!Directory.Exists(destinationDirectory))
                {
                    Directory.CreateDirectory(destinationDirectory);
                }
                string fileName = Path.GetFileName(sourceFilePath);
                string destinationFilePath = Path.Combine(destinationDirectory, fileName);
                File.Copy(sourceFilePath, destinationFilePath, true);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error copying file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

    }
}
