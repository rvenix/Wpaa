using Bridge;

Console.WriteLine("Bridge");

var linuxSystem = new LinuxSystem();
linuxSystem.SystemInterface = new TextInterface();
linuxSystem.DisplayMenu();

var windowsSystem = new WindowsSystem();
windowsSystem.SystemInterface = new Graphicalnterface();
windowsSystem.DisplayMenu();