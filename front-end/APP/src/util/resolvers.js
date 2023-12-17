function imageResolver(imgArray) {
  console.log(imgArray);
}

function timeResolver(t1, t2) {
  const diff = (t2 - t1) / (1000 * 60);
  const minutes = diff % 3600;
  const hours = minutes / 60;
  const roundedHours = Math.floor(hours);
  const min = (hours - roundedHours) * 60;
  const roundedMinutes = Math.round(min);

  // console.log(rhours + " hours and " + rminutes + " minutes.");
  return roundedHours + " hours and " + roundedMinutes + " minutes.";
}

function formatCurrency(value) {
  return new Intl.NumberFormat("bg", {
    style: "currency",
    currency: "BGN",
  }).format(value);
}

export { imageResolver, timeResolver, formatCurrency };
