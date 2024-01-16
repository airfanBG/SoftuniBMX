import styles from "./OrderPartStatistic.module.css";

import { useEffect, useState } from "react";

import { environment } from "../../../environments/environment.js";
import LoaderWheel from "../../LoaderWheel.jsx";
import { get } from "../../../util/api.js";

import { User } from "@phosphor-icons/react";
import { formatCurrency } from "../../../util/resolvers.js";

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

        // console.log(result);
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
            <h3 className={styles.boardHeading}>Select time period</h3>
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
            <div className={styles.summary}>
              <h3 className={styles.infoHeading}>Summary information</h3>
              <p className={styles.info}>
                <span>Total income:</span>
                {!formatCurrency(
                  resultObject.orderStatistics?.totalIncome
                ).includes("NaN")
                  ? formatCurrency(resultObject.orderStatistics?.totalIncome)
                  : formatCurrency(0)}
                {/* {resultObject.orderStatistics?.totalIncome} BGN */}
              </p>
              <p className={styles.info}>
                <span>Total sended orders:</span>
                {resultObject.orderStatistics?.totalSendedOrdersCount} Pcs.
              </p>
            </div>
            <div className={styles.intervalInfo}>
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
          <h3 className={styles.infoHeading}>Best seler part:</h3>
          <figure className={styles.figure}>
            <div className={styles["imgHolder"]}>
              {resultObject.totalPartStatistics?.partName ? (
                <img
                  className={styles.tumbs}
                  src={resultObject.totalPartStatistics?.imageUrl}
                  alt={`${resultObject.totalPartStatistics?.partName} image`}
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
              <h2 className={styles.heading}>
                {resultObject.totalPartStatistics?.partName}
              </h2>
              <p className={`${styles.info}`}>
                <span>Part name:</span>
                {resultObject.totalPartStatistics?.partName}
              </p>
              <div className={styles.infoBox}>
                <p className={`${styles.info}`}>
                  <span>Serial number:</span>
                  {resultObject.totalPartStatistics?.serialNumber}
                </p>
                <p className={`${styles.info}`}>
                  <span>Solded count:</span>
                  {resultObject.totalPartStatistics?.partSoldCount} Pcs.
                </p>
                <p className={`${styles.info}`}>
                  <span>Income:</span>
                  {!formatCurrency(
                  resultObject.totalPartStatistics?.partIncome
                ).includes("NaN")
                  ? formatCurrency(resultObject.totalPartStatistics?.partIncome)
                  : formatCurrency(0)}
                  {/* {resultObject.partTotalStatistics?.partIncome} BGN */}
                </p>
              </div>
            </section>
          </figure>
        </div>
      </section>

      <>
        <h2 className={styles.infoHeading}>Orders in selected time interval:</h2>
        <section className={styles.board}>
          <div>
            <h3 className={styles.infoHeading}>
              Best seler part for selected period:
            </h3>
            <figure className={styles.figure}>
              <div className={styles["imgHolder"]}>
                {resultObject.periodPartStatistics?.partName ? (
                  <img
                    className={styles.tumbs}
                    src={resultObject.periodPartStatistics?.imageUrl}
                    alt={`${resultObject.periodPartStatistics?.partName} image`}
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
                <h2 className={styles.heading}>
                  {resultObject.periodPartStatistics?.partName}
                </h2>
                <p className={`${styles.info}`}>
                  <span>Part name:</span>
                  {resultObject.periodPartStatistics?.partName}
                </p>
                <div className={styles.infoBox}>
                  <p className={`${styles.info}`}>
                    <span>Serial number:</span>
                    {resultObject.periodPartStatistics?.serialNumber}
                  </p>
                  <p className={`${styles.info}`}>
                    <span>Solded count:</span>
                    {resultObject.periodPartStatistics?.partSoldCount} Pcs.
                  </p>
                  <p className={`${styles.info}`}>
                    <span>Income:</span>
                    {!formatCurrency(
                  resultObject.periodPartStatistics?.partIncome
                ).includes("NaN")
                  ? formatCurrency(resultObject.periodPartStatistics?.partIncome)
                  : formatCurrency(0)}
                    {/* {resultObject.partPeriodStatistics?.partIncome} BGN */}
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
