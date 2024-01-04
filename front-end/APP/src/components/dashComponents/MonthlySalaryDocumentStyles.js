import {
  Document,
  Page,
  Text,
  View,
  StyleSheet,
  PDFViewer,
} from "@react-pdf/renderer";

// Create styles
export const styles = StyleSheet.create({
  page: {
    backgroundColor: "#fff",
    color: "black",
  },
  viewer: {
    width: "100%",
    height: "650px",
  },
  header: {
    margin: 10,
    padding: 10,
    backgroundColor: "#E0DEE4",
    border: "1px solid black",
    display: "flex",
    flexDirection: "row",
    justifyContent: "space-between",
    alignItems: "center",
    fontSize: "14px",
  },
  headerField: {
    fontSize: "10px",
    marginBottom: "10px",
  },
  empName: {
    // width: "100%",
    fontSize: "14px",
  },
  headerBlock: {
    textAlign: "right",
    display: "flex",
    flexDirection: "row",
    justifyContent: "flex-end",
    alignItems: "center",
    gap: "12px",
    margin: "2 0",
  },
  flex: {
    display: "flex",
    flexDirection: "row",
    justifyContent: "flex-end",
    alignItems: "flex-end",
    gap: "10px",
  },

  fieldName: {
    textAlign: "left",
    fontSize: "10px",
    color: "#6C6C6C",
    textTransform: "uppercase",
  },
  fieldContent: {
    fontSize: "12px",
    textAlign: "left",
  },

  content: {
    margin: "0 10",
    padding: "10 20",
    border: "1px solid black",
  },
  row: {
    display: "flex",
    flexDirection: "row",
    justifyContent: "space-between",
    alignItems: "center",
    fontSize: "14px",
    padding: "1 0",
  },
  lastRow: {
    display: "flex",
    flexDirection: "row",
    justifyContent: "space-between",
    alignItems: "center",
    fontSize: "14px",
    paddingBottom: "5px",
    borderBottom: "1px solid gray",
  },
  witheSpace: {
    width: "100%",
    height: "20px",
  },
  lastLine: {
    backgroundColor: "#E0DEE4",
    display: "flex",
    flexDirection: "row",
    justifyContent: "space-between",
    alignItems: "center",
    fontSize: "14px",
    padding: "5px",
    border: "1px solid gray",
  },
});
