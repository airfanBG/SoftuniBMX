namespace BicycleApp.Services.Services.Interfaces
{
    public interface IPictureOrganizerServices
    {
        string SaveClientPicture(byte[] file, string fileType, string roothFilePath, string clientIdentification);

        string SaveEmployeePicture(byte[] file, string fileType, string roothFilePath, string employeeIdentitycation);

        string SavePartPicture(byte[] file, string fileType, string roothFilePath, string partIdentification);

        string DeleteFile(string filePath);
    }
}
