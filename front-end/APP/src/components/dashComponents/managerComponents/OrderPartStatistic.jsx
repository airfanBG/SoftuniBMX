import styles from "./OrderPartStatistic.module.css";

import { useEffect, useState } from "react";

import { environment } from "../../../environments/environment.js";
import LoaderWheel from "../../LoaderWheel.jsx";
import { get } from "../../../util/api.js";

import { User } from "@phosphor-icons/react";

function OrderPartStatistic() {
  const [error, setError] = useState({});
  const [loading, setLoading] = useState(false);
  const [resultObject, setResultObject] = useState({});

  // State to hold user input
  const [startDate, setStartDate] = useState("2023-04-11");
  const [endDate, setEndDate] = useState(
    new Date().toLocaleDateString("en-CA")
  );

  // function getLastMonth() {
  //   let [year, month, day] = new Date().toLocaleDateString("en-CA").split("-");
  //   if (month === 1) {
  //     month = 12;
  //     year = year - 1;
  //   }
  //   console.log(`${year}-${month}-${day}`);
  //   return `${year}-${month - 1}-${day}`;
  // }

  useEffect(
    function () {
      setLoading(true);
      console.log("in");
      const abortController = new AbortController();

      async function getStatistics() {
        const queryString = `?startDate=${startDate}&endDate=${endDate}`;
        const result = await get(
          environment.statistic_orders_part + queryString
        );
        if (!result) {
          setLoading(false);
          return setError({
            message: "Something went wrong. Service can not get data!",
          });
        }

        console.log(result);
        setResultObject(result);
        setLoading(false);
      }
      getStatistics();

      return () => abortController.abort();
    },
    [startDate, endDate]
  );

  //const{orderStatistics, partStatistics} = resultObject;

  // console.log(orderStatistics.totalIncome);
  // console.log(partStatistics.totalBestselerPartIncome);

  return (
    <>
      <section className={styles.board}>
        {loading && <LoaderWheel />}
        <div className={styles.dateContainer}>
          <div className={styles.element}>
            <h2 className={styles.boardHeading}>Select time period:</h2>
            <section className={styles.section}>
              <form className={styles.form}>
                <label className={styles.label}>
                  Start Date:
                  <input
                    className={styles.input}
                    type="date"
                    value={startDate}
                    onChange={(e) =>
                      setStartDate(
                        new Date(e.target.value).toLocaleDateString("en-CA")
                      )
                    }
                  />
                </label>
                <label className={styles.label}>
                  End Date:
                  <input
                    className={styles.input}
                    type="date"
                    value={endDate}
                    onChange={(e) =>
                      setEndDate(
                        new Date(e.target.value).toLocaleDateString("en-CA")
                      )
                    }
                  />
                </label>
              </form>
            </section>
          </div>
          <aside className={styles.block}>
            <div>
              <h3 className={styles.infoHeading}>Summary information</h3>
              <p className={styles.info}>
                <span>Total income:</span>
                {resultObject.orderStatistics?.totalIncome} BGN
              </p>
              <p className={styles.info}>
                <span>Total sended orders:</span>
                {resultObject.orderStatistics?.totalSendedOrdersCount} Pcs.
              </p>
            </div>
            <div>
              <h3 className={styles.infoHeading}>
                Information about selecting date interval
              </h3>
              <ul className={styles.list}>
                <li>
                  On initial render will be displayed all available orders
                </li>
                <li>
                  If select start date will limit the interval between selected
                  date and today
                </li>
                <li>
                  When select start and end date will be displayed only orders,
                  created in selected time interval
                </li>
              </ul>
            </div>
          </aside>
        </div>
        <div>
          <h3 className={styles.infoHeading}>
            Best seler part:
          </h3>
          <figure className={styles.figure}>
            <div className={styles["imgHolder"]}>
              {resultObject.partTotalStatistics?.partName ? (
                <img
                  className={styles.tumbs}
                  src={resultObject.partTotalStatistics?.imageUrl}
                  alt={`${resultObject.partTotalStatistics?.partName} image`}
                />
              ) : (
                <User
                  size={48}
                  color="#363636"
                  weight="thin"
                  className={styles.baseImg}
                />
              )}
            </div>
            <section className={styles.workerInfo}>
              <h2 className={styles.heading} >
                {resultObject.employeeFullStatistics?.proudWorkerName}
              </h2>
              <p className={`${styles.info}`}>
                <span>Part name:</span>
                {resultObject.partTotalStatistics?.partName}
              </p>
              <div className={styles.infoBox}>
                <p className={`${styles.info}`}>
                  <span>Serial number:</span>
                  {resultObject.partTotalStatistics?.serialNumber}
                </p>
                <p className={`${styles.info}`}>
                  <span>Solded count:</span>
                  {resultObject.partTotalStatistics?.partSoldCount} Pcs.
                </p>
                <p className={`${styles.info}`}>
                  <span>Income:</span>
                  {resultObject.partTotalStatistics?.partIncome} BGN
                </p>
              </div>
            </section>
          </figure>
        </div>
      </section>

      <>
        <h2 className={styles.dashHeading}>
          Orders in selected time interval:
        </h2>

        <section className={styles.board}>
          <p className={styles.info}>
            <span>Total income:</span>
            {resultObject.orderStatistics?.incomeForSelectedPeriod} BGN
          </p>
          <p className={styles.info}>
            <span>Total sended orders:</span>
            {
              resultObject.orderStatistics?.sendedOrdersCountForSelectedPeriod
            }{" "}
            Pcs.
          </p>


          <div>
            <h3 className={styles.infoHeading}>
              Best seler part for selected period:
            </h3>
            <figure className={styles.figure}>
              <div className={styles["imgHolder"]}>
                {resultObject.partPeriodStatistics?.partName ? (
                  <img
                    className={styles.tumbs}
                    src={resultObject.partPeriodStatistics?.imageUrl}
                    alt={`${resultObject.partPeriodStatistics?.partName} image`}
                  />
                ) : (
                  <User
                    size={48}
                    color="#363636"
                    weight="thin"
                    className={styles.baseImg}
                  />
                )}
              </div>
              <section className={styles.workerInfo}>
                <h2 className={styles.heading} >
                  {resultObject.partPeriodStatistics?.proudWorkerName}
                </h2>
                <p className={`${styles.info}`}>
                  <span>Part name:</span>
                  {resultObject.partPeriodStatistics?.partName}
                </p>
                <div className={styles.infoBox}>
                  <p className={`${styles.info}`}>
                    <span>Serial number:</span>
                    {resultObject.partPeriodStatistics?.serialNumber}
                  </p>
                  <p className={`${styles.info}`}>
                    <span>Solded count:</span>
                    {resultObject.partPeriodStatistics?.partSoldCount} Pcs.
                  </p>
                  <p className={`${styles.info}`}>
                    <span>Income:</span>
                    {resultObject.partPeriodStatistics?.partIncome} BGN
                  </p>
                </div>
              </section>
            </figure>
          </div>
        </section>
      </>
    </>
  );
}

export default OrderPartStatistic;
