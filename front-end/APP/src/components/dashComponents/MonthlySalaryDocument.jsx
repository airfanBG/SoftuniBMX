import { Document, Page, Text, View, PDFViewer } from "@react-pdf/renderer";
import { styles } from "./MonthlySalaryDocumentStyles.js";
import { useContext } from "react";
import { UserContext } from "../../context/GlobalUserProvider.jsx";

function MonthlySalaryDocument() {
  const { user } = useContext(UserContext);

  return (
    <PDFViewer style={styles.viewer}>
      {/* Start of the document*/}
      <Document>
        {/*render a single page*/}
        <Page size="A5" style={styles.page} orientation={"landscape"}>
          <View style={styles.header}>
            <View style={{ width: "50%" }}>
              <Text>eXtreme - BMX</Text>
              <Text style={styles.headerField}>Bicycle Management</Text>
              <Text style={styles.headerField}>ID# {user.id}</Text>
              <Text style={styles.headerField}>
                Name:{" "}
                <Text style={styles.empName}>
                  {user.firstName} {user.lastName}
                </Text>
              </Text>
            </View>
            <View style={{ width: "50%" }}>
              <Text style={{ textAlign: "right" }}>
                {new Date().toLocaleDateString("de-DE")}
              </Text>
              <View style={styles.headerBlock}>
                <Text style={styles.fieldName}>Work days:</Text>
                <Text style={styles.fieldContent}>20</Text>
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
                <Text style={styles.fieldName}>Base Salary:</Text>
                <Text style={styles.fieldContent}>1000.00 BGN</Text>
              </View>
              <View style={styles.flex}>
                <Text style={styles.fieldName}>Department:</Text>
                <Text style={styles.fieldContent}>Frameworker</Text>
              </View>
            </View>
            <View style={styles.row}>
              <View style={styles.flex}>
                <Text style={styles.fieldName}>Position:</Text>
                <Text style={styles.fieldContent}>Master</Text>
              </View>
              <View style={styles.flex}>
                <Text style={styles.fieldName}>Hire Date:</Text>
                <Text style={styles.fieldContent}>02.10.2000</Text>
              </View>
            </View>

            <View style={styles.row}>
              <View style={styles.flex}>
                <Text style={styles.fieldName}>Base hours:</Text>
                <Text style={styles.fieldContent}>160</Text>
              </View>
              <View style={styles.flex}>
                <Text style={styles.fieldName}>Gained:</Text>
                <Text style={styles.fieldContent}>125.45 BGN</Text>
              </View>
            </View>
            <Text style={styles.witheSpace}></Text>
            <View style={styles.lastLine}>
              <View style={styles.flex}>
                <Text style={styles.fieldName}>Base hours:</Text>
                <Text style={styles.fieldContent}>160</Text>
              </View>
              <View style={styles.flex}>
                <Text style={styles.fieldName}>Total:</Text>
                <Text style={styles.fieldContent}>1125.45 BGN</Text>
              </View>
            </View>
          </View>
        </Page>
      </Document>
    </PDFViewer>
  );
}

export default MonthlySalaryDocument;
