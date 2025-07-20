using FacadePattern;

var tv = new UnderSystem.TV();
var soundSystem = new UnderSystem.SoundSystem();
var streamingService = new UnderSystem.StreamingService();

//Dİ ilə də buraya tətbiq edilə bilər
var homeTheater = new HomeTheaterFacade(tv, soundSystem, streamingService);
homeTheater.WatchMovie();