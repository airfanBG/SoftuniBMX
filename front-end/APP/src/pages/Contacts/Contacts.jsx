import React from "react";
import Navigation from "../../components/navigationsComponents/Navigation";
import Footer from "../../components/Footer";
import styles from "./Contacts.module.css";
import GoogleMap from "../../components/GoogleMap";
import ContactForm from "../../components/ContactForm";

function ContactInfo() {
  return (
    <div>
      <Navigation />
      <div className={styles.container}>
        <div className={styles.content}>
          <div className={styles.contactInfo}>
            <h2>Contact Information</h2>
            <p>
              Name: <span>extremeBMX LTD</span>
            </p>
            <p>
              Phone: <span>+359878258496</span>
            </p>
            <p>
              Email: <span>bicyclemanagementextreme@abv.bg</span>
            </p>
            <p>
              Main office: <span>ul. Filip Avramov, 1712 Mladost 3, Sofia</span>
            </p>
            <p className={styles.locations}>
              Our locations:
            </p>
          </div>
          <GoogleMap />
          <ContactForm />
        </div>
      </div>
      <Footer />
    </div>
  );
}

export default ContactInfo;
