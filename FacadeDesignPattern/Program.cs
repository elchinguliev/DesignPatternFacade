using FacadeDesignPattern;

var facade = new FacadeCar();
facade.CreateCar();

Console.WriteLine("\n\n");
var model = new Model();
model.CreateModel();
var motor = new Motor();
motor.CreateMotor();
var body = new Body();
body.CreateBody();
var features = new Features();
features.CreateFeature();


