using Flyweight;

TextureFactory textureFactory = new TextureFactory();

GameObject krzeslo1 = new GameObject("Krzesło1");
krzeslo1.AddTexture(textureFactory.GetTextureByName("nogaKrzesła.jpg"));
krzeslo1.AddTexture(textureFactory.GetTextureByName("oparcieKrzesla.jpg"));

GameObject krzeslo2 = new GameObject("Krzesło2");
krzeslo2.AddTexture(textureFactory.GetTextureByName("nogaKrzesła.jpg"));
krzeslo2.AddTexture(textureFactory.GetTextureByName("oparcieKrzesla.jpg"));

GameObject pilka1 = new GameObject("Piłka1");
pilka1.AddTexture(textureFactory.GetTextureByName("pilka.jpg"));
pilka1.AddTexture(textureFactory.GetTextureByName("napis.jpg"));

GameObject pilka2 = new GameObject("Piłka2");
pilka2.AddTexture(textureFactory.GetTextureByName("pilka.jpg"));
pilka2.AddTexture(textureFactory.GetTextureByName("napis.jpg"));

krzeslo1.RenderObject();
krzeslo2.RenderObject();

pilka1.RenderObject();
pilka2.RenderObject();