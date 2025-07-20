using StrategyPattern;

var traveler = new Traveler(new WalkStrategy());
traveler.Go(); // Piyada işə gedirəm.

traveler.SetStrategy(new CarStrategy());
traveler.Go(); // Maşınla işə gedirəm.

traveler.SetStrategy(new BikeStrategy());
traveler.Go(); // Velosipedlə işə gedirəm.