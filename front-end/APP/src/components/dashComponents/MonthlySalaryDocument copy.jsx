import { Document, Page, Text, View, PDFViewer } from "@react-pdf/renderer";
import { styles } from "./MonthlySalaryDocumentStyles.js";
import { useContext } from "react";
import { UserContext } from "../../context/GlobalUserProvider.jsx";
import {
  formatCurrency,
  getMonthName,
  getWeekdaysInMonth,
} from "../../util/resolvers.js";

function MonthlySalaryDocument() {
  const { user } = useContext(UserContext);
  const { firstName, lastName } = user;
  const salaryMonth = user.salary.month.split(" ").at(0).replaceAll("/", ".");
  const base = formatCurrency(Number(user.salary.baseSalary)).replace(
    "лв.",
    "BGN"
  );
  const bonus = formatCurrency(user.salary.monthBonus).replace("лв.", "BGN");
  const ddo = formatCurrency(user.salary.doo).replace("лв.", "BGN");
  const dzpo = formatCurrency(user.salary.dzpo).replace("лв.", "BGN");
  const zo = formatCurrency(user.salary.zo).replace("лв.", "BGN");
  const ddfl = formatCurrency(user.salary.ddfl).replace("лв.", "BGN");
  const net = formatCurrency(user.salary.netSalary).replace("лв.", "BGN");
  const month = getMonthName();
  let year = new Date().getFullYear();
  if (month === "December" && new Date().getMonth() === 0) {
    year--;
  }
  // console.log(base);
  return (
    <PDFViewer style={styles.viewer}>
      <Document>
        <Page size="A5" style={styles.page} orientation={"landscape"}>
          <View style={styles.header}>
            <View style={{ width: "50%" }}>
              <Text>eXtreme - BMX</Text>
              <Text style={styles.headerField}>Bicycle Management</Text>
              <Text style={styles.headerField}>ID# {user.id}</Text>
              <Text style={styles.headerField}>
                Name:{" "}
                <Text style={styles.empName}>
                  {firstName} {lastName}
                </Text>
              </Text>
            </View>
            <View style={{ width: "50%" }}>
              <Text style={{ textAlign: "right" }}>
                {/* {new Date().toLocaleDateString("de-DE")} */}
                {salaryMonth}
              </Text>
              <View style={styles.headerBlock}>
                <Text style={styles.fieldName}>Work days:</Text>
                <Text style={styles.fieldContent}>{getWeekdaysInMonth()}</Text>
              </View>
              <View style={styles.headerBlock}>
                <Text style={styles.fieldName}>Worked days:</Text>
                <Text style={styles.fieldContent}>20</Text>
              </View>
              <View style={styles.headerBlock}>
                <Text style={styles.fieldName}>Worked hours:</Text>
                <Text style={styles.fieldContent}>98</Text>
              </View>
            </View>
          </View>

          <View style={styles.content}>
            <View style={styles.row}>
              <View style={styles.flex}>
                <Text style={styles.fieldName}>Department:</Text>
                <Text style={styles.fieldContent}>Frameworker</Text>
              </View>
              <View style={styles.flex}>
                <Text style={styles.fieldName}>Base Salary:</Text>
                <Text style={styles.fieldContent}>{base}</Text>
              </View>
            </View>
            <View style={styles.row}>
              <View style={styles.flex}>
                <Text style={styles.fieldName}>Position:</Text>
                <Text style={styles.fieldContent}>Master</Text>
              </View>
              <View style={styles.flex}>
                <Text style={styles.fieldName}>Bonuses:</Text>
                <Text style={styles.fieldContent}>{bonus}</Text>
              </View>
            </View>

            <View style={styles.row}>
              <View style={styles.flex}>
                <Text style={styles.fieldName}>Base hours:</Text>
                <Text style={styles.fieldContent}>160</Text>
              </View>
              <View style={styles.flex}>
                <Text style={styles.fieldName}>DDO:</Text>
                <Text style={styles.fieldContent}>{ddo}</Text>
              </View>
            </View>

            <View style={styles.row}>
              <View style={styles.flex}>
                <Text style={styles.fieldName}>Hire Date:</Text>
                <Text style={styles.fieldContent}>02.10.2000</Text>
              </View>
              <View style={styles.flex}>
                <Text style={styles.fieldName}>DZPO:</Text>
                <Text style={styles.fieldContent}>{dzpo}</Text>
              </View>
            </View>

            <View style={styles.row}>
              <View style={styles.flex}>
                <Text style={styles.fieldName}>Salary month</Text>
                <Text style={styles.fieldContent}>
                  {getMonthName()} - {year}
                </Text>
              </View>
              <View style={styles.flex}>
                <Text style={styles.fieldName}>DDFL:</Text>
                <Text style={styles.fieldContent}>{ddfl}</Text>
              </View>
            </View>

            {/* <View style={styles.row}>
              <View style={styles.flex}>
                <Text style={styles.fieldName}></Text>
                <Text style={styles.fieldContent}></Text>
              </View>
              <View style={styles.flex}>
                <Text style={styles.fieldName}>Net salary:</Text>
                <Text style={styles.fieldContent}>{net}</Text>
              </View>
            </View> */}
            <View style={styles.row}>
              <View style={styles.flex}>
                <Text style={styles.fieldName}></Text>
                <Text style={styles.fieldContent}></Text>
              </View>
              <View style={styles.flex}>
                <Text style={styles.fieldName}>Health Ins:</Text>
                <Text style={styles.fieldContent}>{zo}</Text>
              </View>
            </View>

            <Text style={styles.witheSpace}></Text>
            <View style={styles.lastLine}>
              <View style={styles.flex}>
                <Text style={styles.fieldName}>Base hours:</Text>
                <Text style={styles.fieldContent}>160</Text>
              </View>
              <View style={styles.flex}>
                <Text style={styles.fieldName}>Net salary:</Text>
                <Text style={styles.fieldContent}>{net}</Text>
              </View>
            </View>
          </View>
        </Page>
      </Document>
    </PDFViewer>
  );
}

export default MonthlySalaryDocument;
