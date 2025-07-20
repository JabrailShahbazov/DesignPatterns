using CommandPattern;

var light = new Light();
var lightOnCommand = new TurnOnLightCommand(light);
var button = new Button(lightOnCommand);

button.Press(); // 💡 Işıq yandı.