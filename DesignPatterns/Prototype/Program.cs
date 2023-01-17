using Prototype;

CloudManager cloudManager = new();

cloudManager["default"] = new Cloud("white", "blue");
cloudManager["custom"] = new Cloud("white", "orange");

_ = cloudManager["default"].Clone();
_ = cloudManager["default"].Clone();
_ = cloudManager["custom"].Clone();

Console.ReadKey();
