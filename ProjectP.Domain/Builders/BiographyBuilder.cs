using ProjectP.Domain.Entities;

namespace ProjectP.Domain.Builders;

public class BiographyBuilder
{
    private Biography biography;

    public BiographyBuilder(User user)
    {
        biography = new Biography();
        biography.User = user;
        biography.UserId = user.Id;
    }

    public BiographyBuilder WithAboutMe(string aboutMe)
    {
        biography.AboutMe = aboutMe;
        return this;
    }

    public BiographyBuilder ForBusiness(string address, string zipCode)
    {
        biography.Address = address;
        biography.ZipCode = zipCode;
        return this;
    }

    public BiographyBuilder ForMedia(string youtube, string facebook = "")
    {
        biography.YouTube = youtube;
        biography.Facebook = facebook;
        return this;
    }

    public Biography Build()
    {
        return biography;
    }
}