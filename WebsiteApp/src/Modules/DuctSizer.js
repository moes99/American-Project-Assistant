//Global constants
const DENSITY_AIR = 0.075; // lb/ft^3 at standard conditions
const VISCOSITY_AIR = 0.0000181; // lb/(ft·s) at standard conditions
const KINEMATIC_VISCOSITY_AIR = VISCOSITY_AIR / DENSITY_AIR; // ft^2/s

//Functions
function calcVelocity(flow, size, ductType) {
  //flow in cfm
  //ductType: 'round' or 'rectangular'
  //size can be [diameter] in inches for round or [width, height] in inches for rectangular

  let velocity = 0;
  let area = 0;
  if (ductType == "round" && size.length == 1) {
    // Calculate velocity for round duct
    let diameter = size[0]; // diameter in inches
    area = Math.PI * Math.pow(diameter / 2, 2); // area in square inches
    velocity = (flow / area) * 144; // convert in2 to ft2
  } else if (ductType == "rectangular" && size.length == 2) {
    // Calculate velocity for rectangular duct
    let width = size[0]; // width in inches
    let height = size[1]; // height in inches
    area = width * height; // area in square inches
    velocity = (flow / area) * 144; // convert in2 to ft2
  } else {
    window.alert(
      "Invalid duct type or size provided. Please check your inputs."
    );
  }
  return velocity.toFixed(2); // return velocity rounded to 2 decimal places
}

function calcHydraulicDiameter(width, height) {
  //width and height in inches
  //returns hydraulic diameter in inches

  if (width <= 0 || height <= 0) {
    window.alert("Width and height must be greater than zero.");
    return 0;
  }

  let hydraulicDiameter = (2 * width * height) / (width + height);
  return hydraulicDiameter.toFixed(2); // return hydraulic diameter rounded to 2 decimal places
}

function calcRe(velocity, diameter) {
  //velocity in ft/min
  //ductType: 'round' or 'rectangular'
  //diameter in inches

  let re = 0;
  if (diameter <= 0) {
    window.alert("Diameter must be greater than zero.");
    return 0;
  } else {
    //Convert velocity from ft/min to ft/s
    let velocityFps = velocity / 60; // convert ft/min to ft/s
    // Convert diameter from inches to feet
    let diameterFeet = diameter / 12;
    // Calculate Reynolds number
    re = (velocityFps * diameterFeet) / KINEMATIC_VISCOSITY_AIR;
  }
  return re.toFixed(2); // return Reynolds number rounded to 2 decimal places
}
