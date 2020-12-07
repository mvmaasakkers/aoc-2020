#!/bin/bash

day=$(printf "%02d" $1)
dayName=Day${day}
dotnet new console -o "${dayName}" -f netcoreapp3.1

cat ./Templates/Program.cs | sed "s/Day00/${dayName}/g" > ./${dayName}/Program.cs 
cat ./Templates/Day00.cs | sed "s/Day00/${dayName}/g" > ./${dayName}/${dayName}.cs
cat ./Templates/Day00.csproj | sed "s/Day00/${dayName}/g" > ./${dayName}/${dayName}.csproj
cp -rf  ./Templates/Input ./${dayName}  

aoc in -d $1 > ./${dayName}/Input/part1.txt

dotnet sln add ./${dayName}  

