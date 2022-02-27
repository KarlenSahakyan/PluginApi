using PluginLibrary.Models;

namespace PluginApi
{
    public class ServiceOperations: IServiceOperations
    {
        private WorkPlace workPlace => WorkPlace.CreateWprkPlace();

        public void AddImage(Image image) => workPlace.AddImage(image);

        public void RemoveImage(Image image) => workPlace.RemoveImage(image);

        public void ChangeImageSize(Image image, int size) => image.ChangeSize(size);

        public void ChangeImageRadius(Image image, int radius) => image.ChangeRadius(radius);

        public List<Effect> GetEffects() => Effect.GetEffects();

        public void AddEffect(Image image, Effect effect)=> image.AddEffect(effect);

        public void RemoveEffect(Image image, Effect effect)=> image.RemoveEffect(effect);

        public string GetImmageEffects(Image image) => image.GetImmageEffects();
    }
}
