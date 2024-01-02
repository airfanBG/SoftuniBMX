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

function getMonthName() {
  // не ми харесва , защото на 31-ви не подава следващия месец
  // const prevMonth = new Date();
  // prevMonth.setMonth(prevMonth.getMonth() - 1);
  // return new Intl.DateTimeFormat("en-GB", { month: "long" }).format(
  //   prevMonth
  // );

  const monthNames = [
    "January",
    "February",
    "March",
    "April",
    "May",
    "June",
    "July",
    "August",
    "September",
    "October",
    "November",
    "December",
  ];

  const lastMont =
    new Date()
      .toLocaleDateString(undefined, {
        month: "numeric",
      })
      .split("/")
      .at(0) - 2;
  return monthNames.at(lastMont);
}

function minutesToHours(t) {
  const hours = parseInt(t / 60);
  const minutes = t % 60;
  return `${hours} hours and ${minutes} minutes`;
}

export {
  imageResolver,
  timeResolver,
  formatCurrency,
  getMonthName,
  minutesToHours,
};
