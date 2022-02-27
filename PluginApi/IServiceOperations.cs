using PluginLibrary.Models;

namespace PluginApi
{
    public interface IServiceOperations
    {
        public void AddImage(Image image);

        public void RemoveImage(Image image);

        public void ChangeImageSize(Image image, int size);

        public void ChangeImageRadius(Image image, int radius);

        public List<Effect> GetEffects();

        public void AddEffect(Image image, Effect effect);

        public void RemoveEffect(Image image, Effect effect);

        public string GetImmageEffects(Image image);
    }
}
