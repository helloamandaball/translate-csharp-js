// Put your code here

////JS version of C# code:

// We must specify the Type of the "names" variable.
//  It is a "List" that can only contain "strings".

const names = [ "Nashville", "Hong Kong", "The back yard", "Earth",
"London", "The mall", "Ryman Auditorium", "The Great Wall of China"]

// Print some output to the terminal (aka. "Console");
console.log("All Place Names:", `${names}`);

// Iterate over each "name" in the "names" list
for (let name of names) {
        console.log(name);
    }

// Outputs a blank line.
console.log("")

// Filter the list to create a new list that only returns place names that start with the word "The".
const theNames = names.filter(name => name.startsWith("The"));

console.log("'The' Place Names:")

for (let name of theNames) {
  console.log(name);
}

