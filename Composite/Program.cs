using Composite;

MenuCategory menu = new MenuCategory("Menu główne");

MenuCategory mainCourses = new MenuCategory("Dania główne");
mainCourses.AddPosition(new MenuPosition("Schabowy z ziemnikami i surówką"));
mainCourses.AddPosition(new MenuPosition("Ryba z frytkami i surówką"));
mainCourses.AddPosition(new MenuPosition("Kurczak w pięciu smakach"));


MenuCategory drinks = new MenuCategory("Alkohole");
drinks.AddPosition(new MenuPosition("Mojito"));
drinks.AddPosition(new MenuPosition("Cosmopolitan"));
drinks.AddPosition(new MenuPosition("Bloody Mary"));

menu.AddPosition(mainCourses);
menu.AddPosition(drinks);

menu.Display();