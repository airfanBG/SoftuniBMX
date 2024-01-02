import { useState } from "react";
import { environment } from "../environments/environment.js";
import Navigation from "./Navigation.jsx";
import React, { useEffect } from "react";
import { get } from "./../util/api.js";
import { useParams } from "react-router-dom";
import Footer from "./Footer.jsx";

function PartInfo() {
  const { partId } = useParams();
  const [data, setData] = useState({});
  let images = [];

  useEffect(() => {
    async function getData() {
      try {
        const result = await get(environment.find_part + partId);
        setData(result);
        images = Array.from(result.images);
      } catch (error) {
        console.error("Error fetching data:", error);
      }
    }

    getData();
  }, [partId]);

  return (
    <>
      <section style={{maxWidth: "100%"}}>
        <div
          style={{
            maxWidth: "100%",
            marginTop: "11rem",
            display: "flex",
            flexDirection: "column",
            alignItems: "center",
          }}
        >
          <Navigation />
          <h2>{data.name}</h2>
          <p>Description: {data.description}</p>
          <p>Intend: {data.intend}</p>
          <p>OEM Number: {data.oemNumber}</p>
          <p>Type: {data.type}</p>
          <p>Category: {data.category}</p>
          <p>Sale Price: {data.salePrice}</p>
          <div>
            <p>Images:</p>
            {data.images &&
              data.images.map((image, index) => (
                <img
                  key={index}
                  src={image}
                  alt={`Part Image ${index + 1}`}
                  style={{ maxWidth: "300px", marginRight: "10px" }}
                />
              ))}
          </div>
        </div>
        <Footer />
      </section>
    </>
  );
}

export default PartInfo;
