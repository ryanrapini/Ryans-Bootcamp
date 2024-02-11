using Backend;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/players", () => {
    Player[] players = new[] {
      new Player(1,"bob"),
      new Player(2,"mike", "OH"),
      new Player(3,"steve")
    };

  players[0].Position = "RS";
  players[2].Position = "MB";

  return players;

});

app.Run();
