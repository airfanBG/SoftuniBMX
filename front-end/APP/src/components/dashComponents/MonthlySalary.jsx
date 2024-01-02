import styles from "./MonthlySalary.module.css";
import {
  Page,
  Text,
  View,
  Document,
  StyleSheet,
  PDFViewer,
  PDFDownloadLink,
} from "@react-pdf/renderer";

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
          {/* <PDFDownloadLink
            document={<MonthlySalaryDocument />}
            fileName="somename.pdf"
          >
            {({ blob, url, loading, error }) =>
              loading ? "Loading document..." : "Download now!"
            }
          </PDFDownloadLink> */}
        </div>
      </section>
    </>
  );
}
export default MonthlySalary;
