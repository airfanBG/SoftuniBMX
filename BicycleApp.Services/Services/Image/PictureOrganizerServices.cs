namespace BicycleApp.Services.Services.Image
{
    using System;

    using BicycleApp.Services.Contracts;

    using static BicycleApp.Common.ApplicationGlobalConstants;

    public class PictureOrganizerServices : IPictureOrganizerServices
    {

        public PictureOrganizerServices()
        {

        }

        /// <summary>
        /// This method receives a file and saves it in a specific folder in the main folder for parts
        /// </summary>
        /// <param name="file">The file that has to be saved</param>
        /// <param name="fileType">The type of the file</param>
        /// <param name="roothFilePath">The filepath to the main directory for files to save</param>
        /// <param name="partIdentification">unique identification of the part</param>
        /// <returns></returns>
        public string SavePartPicture(byte[] file, string fileType, string roothFilePath, string partIdentification)
        {
            ValidateInputData(file, fileType, roothFilePath, partIdentification);

            string partsMainFolderName = Path.Combine(roothFilePath, PartsMainFolderName);

            if (!Directory.Exists(partsMainFolderName))
            {
                Directory.CreateDirectory(partsMainFolderName);
            }

            string currentPartMainFolderName = Path.Combine(partsMainFolderName, partIdentification);

            if (!Directory.Exists(currentPartMainFolderName))
            {
                Directory.CreateDirectory(currentPartMainFolderName);
            }

            string year = DateTime.Now.Year.ToString();
            string currentYearFolderName = Path.Combine(currentPartMainFolderName, year);

            if (!Directory.Exists(currentYearFolderName))
            {
                Directory.CreateDirectory(currentYearFolderName);
            }

            string month = DateTime.Now.Month.ToString();
            string currentMonthFolderName = Path.Combine(currentYearFolderName, month);

            if (!Directory.Exists(currentMonthFolderName))
            {
                Directory.CreateDirectory(currentMonthFolderName);
            }

            string[] existingFolders = Directory.GetDirectories(currentMonthFolderName);
            int nextFolderNumber = existingFolders.Length + 1;
            string currentImageFolderName;
            int filesCount = 0;

            if (existingFolders.Length == 0)
            {
                currentImageFolderName = Path.Combine(currentMonthFolderName, nextFolderNumber.ToString());
            }
            else
            {
                string[] orderedFolders = existingFolders.OrderBy(x => x).ToArray();
                string lastFolder = orderedFolders[orderedFolders.Length - 1];
                string[] files = Directory.GetFiles(lastFolder);
                filesCount = files.Length;

                if (filesCount >= DefaultMaxCountOfPicturesInOneFolder)
                {
                    currentImageFolderName = Path.Combine(currentMonthFolderName, nextFolderNumber.ToString());
                }
                else
                {
                    currentImageFolderName = lastFolder;
                }
            }

            if (!Directory.Exists(currentImageFolderName))
            {
                Directory.CreateDirectory(currentImageFolderName);
            }

            string newFileName = CreateFileName(currentImageFolderName, partIdentification);

            string imagePath = SaveFile(file, fileType, newFileName, currentImageFolderName);

            return imagePath;
        }

        /// <summary>
        /// This method received a path to a file and deletes it
        /// </summary>
        /// <param name="filePath">The path to the file</param>
        /// <returns>Returns informasion if the file deleted</returns>
        public string DeleteFile(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                    return "File deleted!";
                }
                else
                {
                    return $"File '{filePath}' does not exist and cannot be deleted!";
                }
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
        }

        /// <summary>
        /// This method validates the input data for the SavePicture methods
        /// </summary>
        /// <param name="file">The file to be saves</param>
        /// <param name="fileType">The type of the file</param>
        /// <param name="roothFilePath">The path to the main folder</param>
        /// <param name="identificationData">unique identificaition</param>
        /// <exception cref="ArgumentException">If any of the arguments are invalid an exception will be thrown with a message</exception>
        private void ValidateInputData(byte[] file, string fileType, string roothFilePath, string identificationData)
        {
            if (file == null || file.Length == 0)
            {
                throw new ArgumentException("Invalid file");
            }

            if (string.IsNullOrEmpty(fileType))
            {
                throw new ArgumentException("Invalid file type");
            }

            if (string.IsNullOrEmpty(roothFilePath))
            {
                throw new ArgumentException("Invalid file path");
            }

            if (string.IsNullOrEmpty(identificationData))
            {
                throw new ArgumentException("Invalid client id");
            }
        }

        /// <summary>
        /// This method saves a file with specific name and filetype in to a specific folder
        /// </summary>
        /// <param name="fileData">The file as byte[]</param>
        /// <param name="fileType">The type of the file</param>
        /// <param name="filename">The name of the file</param>
        /// <param name="folderPath">The path to the folder</param>
        /// <returns>Returns the path to the new file</returns>
        private string SaveFile(byte[] fileData, string fileType, string filename, string folderPath)
        {
            string fileExtension = fileType.StartsWith(".") ? fileType : "." + fileType;
            string filePath = Path.Combine(folderPath, filename + fileExtension);

            File.WriteAllBytes(filePath, fileData);

            return filePath;
        }

        /// <summary>
        /// This method creates a name for the new file
        /// </summary>
        /// <param name="folderPath">The path of the new file</param>
        /// <param name="identification">The unique identification of the name</param>
        /// <returns>Returns the new name of the file as String</returns>
        private string CreateFileName(string folderPath, string identification)
        {
            string[] files = Directory.GetFiles(folderPath);
            int count = files.Length + 1;
            return $"{identification}-{count}";
        }
    }
}
