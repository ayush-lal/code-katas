const open = "_@_";
const closed = "_#_";
const doorsCount = 100;

const doors = [];
for (let i = 0; i < doorsCount; doors[i] = closed, i++);

for (let doorPass = 1; doorPass <= doorsCount; doorPass++) {
  for (let i = doorPass - 1; i < doorsCount; i += doorPass) {
    doors[i] = doors[i] == open ? closed : open;
  }
}

let openDoors = [];
let closedDoors = [];

doors.forEach((doorStatus, i) => {
  if (doorStatus == open) {
    openDoors.push(i + 1);
  } else {
    closedDoors.push(i + 1);
  }
});

console.log("These doors are OPEN: " + openDoors.join(", ") + ".");
console.log("These doors are CLOSED: " + closedDoors.join(", ") + ".");
