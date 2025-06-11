# IRUD-Assignment-2
<h2>SECTION 1 ⚔️</h2> <h2>SCENARIO OVERVIEW 🏰</h2> It is vital to maintain a structured design and flexibility in code architecture to guarantee scalability and long-term ease of maintenance in the world of modern gaming, especially within role-playing games (RPGs). **CastleForge**, which is the system described in this assignment, simulates a fantasy battle scenario featuring character types such as **knights 🛡️** and **archers 🏹**, each provided with unique abilities and customizable enhancements. The main objective is to effectively manage character actions, upgrades, and the overall game state, demonstrating solid software design principles through the application of **design patterns 📐**.
The CastleForge Battle System is built around three fundamental components:

<b>Game Management</b> 🧠: This refers to the centralized supervision of game events through a singleton class known as GameManager 🧭, which ensures that all logs and interactions are controlled from a single access point.

Character Actions 🎯: Actions that are done by characters, such as attacking, defending, and healing, are abstracted through a command structure that supports undoable actions 🔁.

Character Enhancement ✨: The enhancement of base characters like knights and archers is permitted by a decorator pattern 🎨. This enables them to equip magical weapons and armour 🗡️🛡️ at runtime.

To understand this system, one must understand the relationships and interactions between factories 🏗️, commands 📝, enhancements 💎, and state management 🧾. The design encourages flexibility, allowing new character types or abilities to merge with the slightest adjustments.

<h2>1.2.1 SINGLETON PATTERN 🧍‍♂️</h2> The singleton pattern is a design pattern that ensures a class can only have one concurrent instance. Whenever additional objects of a singleton class are required, the previously created, single instance is provided. <ul> <li>Class: <strong>GameManager 🧭</strong></li> <li>Purpose: Ensures there is only one instance managing the battle logs and game state 📜.</li> <li>Usage: All commands and system messages log to this centralized class 🗂️.</li> </ul>
<h2>1.2.2 COMMAND PATTERN 📝</h2> The command pattern enables all of the information for a request to be contained within a single object. The command can then be invoked as required, often as part of a batch of queued commands with rollback capabilities 🔁. <ul> <li>Classes: <strong>AttackCommand ⚔️, DefendCommand 🛡️, HealCommand 💊, BattleCommander 🪖</strong></li> <li>Purpose: Encapsulates character actions into executable and undoable commands 🎮.</li> <li>Usage: Provides decoupling between the invoker (BattleCommander 🧞‍♂️) and the receiver (Character 👤).</li> </ul>
<h2>1.2.3 DECORATOR PATTERN 🎨</h2> The decorator pattern extends the functionality of individual objects by wrapping them with one or more decorator classes. These decorators can modify existing members and add new methods and properties at run-time 🛠️. <ul> <li>Classes: <strong>CharacterDecorator 🧝, FlameSword 🔥🗡️, DragonSlayer 🐉⚔️, FlamingArrows 🔥🏹</strong></li> <li>Purpose: Allows dynamic addition of enhancements (e.g., weapons, armor) to character objects 🎯.</li> <li>Usage: Promotes flexibility in character customization without modifying the base class 🧩.</li> </ul>

2.1ICOMMAND 

    interface ICommand 
    { 
    void Execute(); 
    void Undo();
    } 
 
2.2 ICHARACTER 

    interface ICharacter //Component 
    { 
     string GetName(); 
     string GetDescription(); 
     int GetPower();
    } 
 
2.3 CHARACTERDECORATOR 

    abstract class CharacterDecorator : ICharacter 
    { 
     protected ICharacter knightCharacter; 
     public CharacterDecorator(ICharacter knightCharacter) 
    { 
     this.knightCharacter = knightCharacter;
    }  

    public virtual string GetName() 
    { 
     return knightCharacter.GetName(); 
    } 

    public virtual string GetDescription() 
    { 
     return knightCharacter.GetDescription(); 
    } 

    public virtual int GetPower() 
    { 
     return knightCharacter.GetPower(); 
    } 

    } 
2.4 BASEKNIGHT 

    class BaseKnight : ICharacter //Concrete Component 
    { 
    
    public string name; 
    
    public BaseKnight(string name) 
    { 
        this.name = name; 
    } 
    
    public string GetName() 
     { 
        return name; 
     } 
    
     public string GetDescription() 
     { 
        return $"The Knight: {name}"; 
     } 
    
     public int GetPower() 
     { 
        return 45; 
     } 
    } 
2.5 BASEARCHER 

    class BaseArcher : ICharacter 
    {  
    
    public string name; 
    public BaseArcher(string archerName) 
    { 
        this.name = archerName; 
    } 
      public string GetName() 
     { 
       return name;
     } 
 
    public string GetDescription() 
    { 
      return $"The Archer: {name}"; 
    } 

     public int GetPower() 
     { 
      return 45; 
     } 
    } 

2.6 FLAMESWORD 

    class FlameSword : CharacterDecorator 
    { 
       public FlameSword(ICharacter kcharacter) : base(kcharacter){} 
       public override string GetDescription() 
      { 
       return base.GetDescription() + "\nEquips Flame Sword "; 
      } 

       public override int GetPower() 
      { 
       return base.GetPower() + 20; 
      } 

    } 


2.7 DRAGONSLAYER 

     class DragonSlayer : CharacterDecorator 
    { 
      public DragonSlayer(ICharacter character) : base(character) 
      { 
      } 
      public override string GetDescription() 
     { 
       return base.GetDescription() + "\nEquips Dragon Slayer Sword "; 
     } 

     public override int GetPower() 
     { 
      return base.GetPower() + 30;
     } 
    } 
 
2.8 FLAMINGARROWS 

    class FlamingArrows : CharacterDecorator 
    { 
       public FlamingArrows(ICharacter kcharacter) : base(kcharacter) { } 
       public override string GetDescription() 
       { 
         return base.GetDescription() + "\nEquips Flaming Arrows "; 
       } 

       public override int GetPower() 
       { 
         return base.GetPower() + 15;
       } 
 
    } 

2.9 ATTACKCOMMAND 

    class AttackCommand : ICommand 
    { 

     private Character knight; 
     
     public AttackCommand(Character warrior) 
     { 
      knight = warrior; 
     } 
 
 
     public void Execute() 
     { 
        knight.Attack(); 
     } 
      public void Undo() 
      { 
        knight.UndoMove(); 
      } 
    } 
2.10 DEFENDCOMMAND 

     class DefendCommand : ICommand 
    { 
       private Character knight; 
       public DefendCommand(Character warrior) 
      { 
        knight = warrior; 
      } 
      public void Execute() 
      { 
        knight.Defend(); 
      } 
       public void Undo() 
      { 
        knight.UndoMove(); 
      } 
    } 
2.11 HEALCOMMAND 

     class HealCommand : ICommand 
    { 
      private Character knight; 
      public HealCommand(Character warrior) 
      { 
        knight = warrior; 
      } 
      public void Execute() 
      { 
        knight.Heal(); 
      } 
      public void Undo() 
      { 
        knight.UndoMove(); 
      } 
    } 
2.12 BATTLECOMMANDER 

     class BattleCommander 
    { 
       private ICommand battleCommand; 
       public void setCommand(ICommand command) 
       { 
        battleCommand = command; 
       } 
       public void executeCommand() 
       { 
        battleCommand.Execute(); 
       } 
    } 
2.13 CHARACTER 

    class Character 
    { 
    
       private ICharacter _character; 
    
       public Character(ICharacter name) 
      { 
        _character = name; 
      } 
      public void Attack() 
      { 
        GameManager.GetGameManger().LogBattle($"{_character.GetName()} lauches an attack!"); 
      } 
       public void Defend() 
      { 
        GameManager.GetGameManger().LogBattle($"{_character.GetName()} puts up his Guard!"); 
      } 
       public void Heal() 
      { 
        GameManager.GetGameManger().LogBattle($"{_character.GetName()} heals up!"); 
      } 
      public void UndoMove() 
      { 
        GameManager.GetGameManger().LogBattle($"{_character.GetName()} Retreats!"); 
      } 
    } 
2.14 GAMEMANAGER 

     class GameManager 
    { 
      private static GameManager gameManager; 
      private static object gameLock = new object(); 
 
      private GameManager(){} 
      public static GameManager GetGameManger() 
      { 
        lock (gameLock) 
        { 
            if(gameManager == null) 
            gameManager = new GameManager();

        { 
        return gameManager; 
     } 
    } 
 

      public void LogBattle(string message) 
     { 
     //Console.WriteLine("[Overseer of the battle]"); 
     Console.WriteLine("Game Manager Log: " + message); 
     } 
    } 

<h2>SECTION 3</h2>
2.15 PROGRAM 

     static void Main(string[] args) 
    { 

      GameManager.GetGameManger().LogBattle("Welcome to CastleForge!"); 
      ICharacter character = new BaseKnight("Adam"); 
      character = new FlameSword(character); 
      character = new DragonSlayer(character); 
      GameManager.GetGameManger().LogBattle($"Character: [{character.GetDescription()} \nPower: 
      [{character.GetPower()}]"); 
      Console.WriteLine("=====ARCHER===="); 
      ICharacter charArch = new BaseArcher("Sudais"); 
      charArch = new FlamingArrows(charArch); 

     GameManager.GetGameManger().LogBattle($"Character: [{charArch.GetDescription()} \nPower: 
     [{charArch.GetPower()}]"); 
     Console.WriteLine(); 
     Character kcommands = new Character(character); 
     BattleCommander bc = new BattleCommander(); 
     bc.setCommand(new AttackCommand(kcommands)); 
     bc.executeCommand(); 
     bc.setCommand(new DefendCommand(kcommands)); 
     bc.executeCommand(); 
     bc.setCommand(new HealCommand(kcommands)); 
     bc.executeCommand(); 
     Console.ReadLine(); 
    }
