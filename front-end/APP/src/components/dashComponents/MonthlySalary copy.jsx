import styles from "./MonthlySalary.module.css";
import { PDFDownloadLink } from "@react-pdf/renderer";

import BoardHeader from "./BoardHeader.jsx";
import MonthlySalaryDocument from "./MonthlySalaryDocument.jsx";
import LoaderWheel from "../LoaderWheel.jsx";
import { useState } from "react";

function MonthlySalary() {
  const [loading, setLoading] = useState(false);

  return (
    <>
      <h2 className={styles.dashHeading}>Salary</h2>
      <section className={styles.board}>
        <BoardHeader />
        {loading && <LoaderWheel />}
        <div className={styles.salaryWrapper}>
          <MonthlySalaryDocument />
          <div className={styles.wallet}>
            <ion-icon name="wallet-outline"></ion-icon>
            {/* <ion-icon name="chevron-down-outline"></ion-icon> */}
            <p className={styles.walletText}>Get money</p>
            {/* <PDFDownloadLink document={<Test />} fileName="somename.pdf">
              {({ blob, url, loading, error }) =>
                loading ? "Loading document..." : "Download now!"
              }
            </PDFDownloadLink> */}
          </div>
        </div>
      </section>
    </>
  );
}
export default MonthlySalary;

function Test() {
  return <div>tests</div>;
}
