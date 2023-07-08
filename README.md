# StatAlgorithim

# Introduction

What is this? This is a multi-use csv parser that can be used in different pro era leagues. 

If a league would like to collect stats, and use these algorithims, they have to follow a certain csv file format. 
(PS. a google form can generate this exactly)

```
Name, Receptions, Passing Touchdowns, Receiving Touchdowns, Rushing Touchdowns, Interceptions Thrown, Interceptions, Sacks, Safeties Converted, Tackles
```

Example Stats.csv file

```
Player A, 55, 20, 10, 5, 8, 3, 12, 2, 70
Player B, 60, 18, 12, 3, 5, 6, 10, 1, 80
Player C, 50, 25, 8, 4, 7, 2, 15, 3, 65
```

# How to use?

It's like really really simple. Gotta call 3 methods.

```cs
StatFile sf = new StatFile("PlayerStats.csv");
```

This ^^ will generate a new StatFile object.

```cs
sf.Players = Validator.AntiCheatCheck(sf.Players);
```

This ^^ is optional, but what it will do is remove any outliers / insanely high numbers. Like if the highest is 900
and the second highest is 6. This has specific use-cases and wont always be used.

Finally,

```cs
sf.PrintBest();
```

Which will print out

```
POTW is - BestName with a score of BestScore and a point differential of BestScore-SecondBestScore over SecondBestName!
```

alright enjoy lol