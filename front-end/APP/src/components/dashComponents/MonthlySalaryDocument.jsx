import {
  Document,
  Page,
  Text,
  View,
  StyleSheet,
  PDFViewer,
} from "@react-pdf/renderer";
// Create styles
const styles = StyleSheet.create({
  page: {
    backgroundColor: "#fff",
    color: "black",
  },
  section: {
    margin: 10,
    padding: 10,
  },
  viewer: {
    // width: window.innerWidth / 2, //the pdf viewer will take up all of the width and height
    // height: window.innerHeight ,
    width: "100%",
    height: "1200px",
  },
  empName: {
    fontSize: "30px",
  },
});
function MonthlySalaryDocument() {
  return (
    <PDFViewer style={styles.viewer}>
      {/* Start of the document*/}
      <Document>
        {/*render a single page*/}
        <Page size="A4" style={styles.page}>
          <View style={styles.section}>
            <Text style={styles.empName}>Hello</Text>
          </View>
          <View style={styles.section}>
            <Text>World</Text>
          </View>
        </Page>
      </Document>
    </PDFViewer>
  );
}

export default MonthlySalaryDocument;
