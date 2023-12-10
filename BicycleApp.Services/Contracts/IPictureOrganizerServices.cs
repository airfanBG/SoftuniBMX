namespace BicycleApp.Services.Contracts
{
    public interface IPictureOrganizerServices
    {
        string SavePartPicture(byte[] file, string fileType, string roothFilePath, string partIdentification);

        string DeleteFile(string filePath);
    }
}
