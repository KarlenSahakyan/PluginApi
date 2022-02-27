using Microsoft.AspNetCore.Mvc;
using PluginLibrary.Models;

namespace PluginApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ImageController : ControllerBase
    {
        IConfiguration config; IServiceOperations serviceOperations;
        public ImageController(IConfiguration config, IServiceOperations serviceOperations)
        {
            this.config = config;
            this.serviceOperations = serviceOperations;
        }
        [HttpPost("AddImage")]
        public void AddImage(Image image) => serviceOperations.AddImage(image);

        [HttpPost("RemoveImage")]
        public void RemoveImage(Image image) => serviceOperations.RemoveImage(image);

        [HttpPost("ChangeImageSize")]
        public void ChangeImageSize(Image image, [FromQuery]int size) => serviceOperations.ChangeImageSize(image, size);

        [HttpPost("ChangeImageRadius")]
        public void ChangeImageRadius(Image image, [FromQuery] int radius) => serviceOperations.ChangeImageRadius(image, radius);


        [HttpGet("GetEffects")]
        public List<Effect> GetEffects() => serviceOperations.GetEffects();

        [HttpPost("AddEffect")]
        public void AddEffect(Image image, [FromQuery] Effect effect) => serviceOperations.AddEffect(image, effect);

        [HttpPost("RemoveEffect")]
        public void RemoveEffect(Image image, [FromQuery] Effect effect) => serviceOperations.RemoveEffect(image, effect);

        [HttpPost("GetImmageEffects")]
        public string GetImmageEffects(Image image) => serviceOperations.GetImmageEffects(image);
    }
}
