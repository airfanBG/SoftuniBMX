import { useContext } from "react";
import styles from "./MonthlySalaryDocument.module.css";
import { Preview, print } from "react-html2pdf";
import { UserContext } from "../../context/GlobalUserProvider.jsx";
import {
  formatCurrency,
  getMonthName,
  getWeekdaysInMonth,
} from "../../util/resolvers.js";

function Salary() {
  const { user } = useContext(UserContext);
  const { firstName, lastName } = user;
  const salaryMonth = user.salary.month.split(" ").at(0).replaceAll("/", ".");
  const base = formatCurrency(Number(user.salary.baseSalary));
  const bonus = formatCurrency(user.salary.monthBonus);
  const ddo = formatCurrency(user.salary.doo);
  const dzpo = formatCurrency(user.salary.dzpo);
  const zo = formatCurrency(user.salary.zo);
  const ddfl = formatCurrency(user.salary.ddfl);
  const net = formatCurrency(user.salary.netSalary);
  const month = getMonthName();
  let year = new Date().getFullYear();
  if (month === "December" && new Date().getMonth() === 0) {
    year--;
  }
  const docName = `Payslips - ${month} - ${year}`;

  return (
    <>
      {/* template */}
      <Preview id={"jsx-template"}>
        <div className={styles.wrapperPDF}>
          <div className={styles.pdfContainer}>
            {/* HEADER */}
            <div className={styles.headerPDF}>
              <div className={styles.header1}>
                <div className={styles.logoPDF}>
                  <div className={styles.logoFirstLinePDF}>
                    e<span>&#10006;</span>treme - BMX
                  </div>
                  <span className={styles.logoSecondaryPDF}>
                    Bicycle Management
                  </span>
                </div>
                <div className={styles.headerContent}>
                  <span className={styles.label}>ID#</span>
                  <p className={`${styles.headerText} ${styles.textId}`}>
                    {user.id}
                  </p>
                </div>
                <div className={styles.headerContent}>
                  <span className={styles.label}>Name: </span>
                  <p className={styles.headerText}>
                    {firstName} {lastName}
                  </p>
                </div>
                {/* <div className={styles.headerContent}>
                  <span className={styles.label}>Date: </span>
                  <p className={styles.headerText}>{salaryMonth}</p>
                </div> */}
              </div>
              <div className={styles.header2}>
                {/* <div className={styles.headerContent}>
                  <span className={styles.label}>Payment for:</span>
                  <p className={styles.headerText}>
                    {month} - {year}
                  </p>
                </div> */}
                <div className={styles.headerContent}>
                  <span className={styles.label}>Date:</span>
                  <p className={styles.headerText}>{salaryMonth}</p>
                </div>

                <div className={styles.headerContent}>
                  <span className={styles.label}>Work days:</span>
                  <p className={styles.headerText}>{getWeekdaysInMonth()}</p>
                </div>

                <div className={styles.headerContent}>
                  <span className={styles.label}>Worked days:</span>
                  <p className={styles.headerText}>{getWeekdaysInMonth()}</p>
                </div>
                <div className={styles.headerContent}>
                  <span className={styles.label}>Worked hours:</span>
                  <p className={styles.headerText}>
                    {getWeekdaysInMonth() * 8}
                  </p>
                </div>
              </div>
            </div>
            {/* MAIN INFO */}
            <div className={styles.infoContainer}>
              <div className={styles.info1}>
                <div className={styles.infoContent}>
                  <span className={styles.infoLabel}>Base salary:</span>
                  <p className={styles.infoText}>{base}</p>
                </div>

                <div className={styles.infoContent}>
                  <span className={styles.infoLabel}>Full salary:</span>
                  <p className={styles.infoText}>
                    {formatCurrency(
                      user.salary.baseSalary +
                        user.salary.monthBonus +
                        user.salary.baseSalary * 0.05
                    )}
                  </p>
                </div>

                <div className={styles.infoContent}>
                  <span className={styles.infoLabel}>Ins income:</span>
                  <p className={styles.infoText}>
                    {formatCurrency(
                      user.salary.baseSalary +
                        user.salary.monthBonus +
                        user.salary.baseSalary * 0.05
                    )}
                  </p>
                </div>

                <div className={styles.infoContent}>
                  <span className={styles.infoLabel}>Tax base:</span>
                  <p className={styles.infoText}>640.14 лв.</p>
                </div>
              </div>

              {/* second */}
              <div className={styles.info2}>
                <div className={styles.infoContent}>
                  <span className={styles.infoLabel}>Bonuses:</span>
                  <p className={styles.infoText}>{bonus}</p>
                </div>

                <div className={styles.infoContent}>
                  <span className={styles.infoLabel}>Min. Ins income:</span>
                  <p className={styles.infoText}>640.00</p>
                </div>

                <div className={styles.infoContent}>
                  <span className={styles.infoLabel}>Position:</span>
                  <p className={styles.infoText}>{user.role}</p>
                </div>

                {/* <div className={styles.infoContent}>
                  <span className={styles.infoLabel}>Hire date:</span>
                  <p className={styles.infoText}>03.11.2023</p>
                </div> */}
              </div>
            </div>

            {/* TABLE INFO */}
            <div className={styles.tableContainer}>
              {/* HEADER */}
              <p className={styles.tableCode}>Code:</p>
              <p className={styles.tableIncome}>Income:</p>
              <p className={styles.tableCount}>Count:</p>
              <p className={styles.tableCorrection}>Corection:</p>
              <p className={styles.tableAmount}>Amount:</p>
              <p className={styles.tableCode2}>Code:</p>
              <p className={styles.tableHolds}>Holds:</p>
              <p className={styles.tableCount2}>Count:</p>
              <p className={styles.tableCorrection2}>Correction:</p>
              <p className={styles.tableAmount2}>Amount:</p>
              {/* firstLine */}
              <div className={styles.tableCode}>101</div>
              <div className={styles.tableIncome}>Base salary</div>

              <div className={styles.tableCount}>
                {getWeekdaysInMonth() * 8} h
              </div>
              <div className={styles.tableCorrection}></div>
              <div className={styles.tableAmount}>{base}</div>
              <div className={styles.tableCode2}>301</div>
              <div className={styles.tableHolds}>DDFL</div>
              <div className={styles.tableCount2}>10%</div>
              <div className={styles.tableCorrection2}></div>
              <div className={styles.tableAmount2}>
                {" "}
                {formatCurrency(user.salary.ddfl)}
              </div>
              {/* secondLine */}
              <div className={styles.tableCode}>102</div>
              <div className={styles.tableIncome}>% class</div>
              <div className={styles.tableCount}>5%</div>
              <div className={styles.tableCorrection}></div>
              <div className={styles.tableAmount}>
                {formatCurrency(user.salary.baseSalary * 0.05)}
              </div>
              <div className={styles.tableCode2}>302</div>
              <div className={styles.tableHolds}>DOO</div>
              <div className={styles.tableCount2}>7.5%</div>
              <div className={styles.tableCorrection2}></div>
              <div className={styles.tableAmount2}>{ddo}</div>
              {/* thirdLine */}
              <div className={styles.tableCode}></div>
              <div className={styles.tableIncome}></div>
              <div className={styles.tableCount}></div>
              <div className={styles.tableCorrection}></div>
              <div className={styles.tableAmount}></div>
              <div className={styles.tableCode2}>303</div>
              <div className={styles.tableHolds}>DZPO</div>
              <div className={styles.tableCount2}>2.2%</div>
              <div className={styles.tableCorrection2}></div>
              <div className={styles.tableAmount2}>{dzpo}</div>
              {/* fourthLine */}
              <div className={styles.tableCode}></div>
              <div className={styles.tableIncome}></div>
              <div className={styles.tableCount}></div>
              <div className={styles.tableCorrection}></div>
              <div className={styles.tableAmount}></div>
              <div className={styles.tableCode2}>304</div>
              <div className={styles.tableHolds}>ZO</div>
              <div className={styles.tableCount2}>3.2%</div>
              <div className={styles.tableCorrection2}></div>
              <div className={styles.tableAmount2}>{zo}</div>
            </div>

            {/* TOTAL INFO */}
            <div className={styles.totalContainer}>
              <div className={styles.totalContent}>
                <p className={styles.totalInfo}>Total incomes:</p>
                <p className={styles.totalInfo2}>
                  {formatCurrency(
                    user.salary.baseSalary +
                      user.salary.monthBonus +
                      user.salary.monthBonus * 0.05
                  )}
                </p>
              </div>
              <div className={styles.totalContent}>
                <p className={styles.totalInfo}>Total holds:</p>
                <p className={styles.totalInfo2}>
                  {formatCurrency(
                    user.salary.doo +
                      user.salary.dzpo +
                      user.salary.zo +
                      user.salary.ddfl
                  )}
                </p>
              </div>
            </div>

            {/* SIGN */}
            <div className={styles.signContainer}>
              {/* <div className={styles.signContent}> */}
              <p className={styles.totalInfo}>Final (amount in words):</p>
              <p className={styles.signInfo2}>
                {formatCurrency(+user.salary.netSalary)}
              </p>
              <p className={styles.totalInfo}></p>
              <p className={styles.sign}>Employee sign:</p>
              {/* </div> */}
            </div>
          </div>
        </div>
      </Preview>
      {/* Print button */}

      <div className={styles.controls}>
        <div className={styles.print}>
          {/* <ion-icon name="print-outline"></ion-icon> */}
          <button
            onClick={() => print(docName, "jsx-template")}
            className={styles.btn}
          >
            <ion-icon name="print-outline"></ion-icon>
          </button>
          <button className={styles.btn}>
            <ion-icon name="wallet-outline"></ion-icon>
          </button>
        </div>
        {/* <div className={styles.wallet}>
          <ion-icon name="wallet-outline"></ion-icon>
          <p className={styles.walletText}>Get money</p>
        </div> */}
      </div>
      {/* </section> */}
    </>
  );
}

export default Salary;
