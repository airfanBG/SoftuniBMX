import React, { useEffect } from "react";

function GoogleMap() {
  useEffect(() => {
    const script = document.createElement("script");
    script.src = `https://maps.googleapis.com/maps/api/js?key=AIzaSyA46nWTbviuYqcTQhOKnXP735fNWA_GBFw&callback=initMap`;
    script.async = true;
    script.defer = true;
    document.head.appendChild(script);

    window.initMap = () => {
      const mapOptions = {
        center: { lat: 42.6977, lng: 23.3219 },
        zoom: 7,
      };

      const map = new window.google.maps.Map(
        document.getElementById("map"),
        mapOptions
      );

      const addresses = [
        {
          name: "ul. Filip Avramov, 1712 Mladost 3, Sofia",
          coordinates: { lat: 42.644429, lng: 23.387209 },
        },
        {
          name: "bul. Hristo Botev No.4B, 9000 Varna",
          coordinates: { lat: 43.206217, lng: 27.911967 },
        },
        {
          name: "ul. Perushtitsa 8, 4002 Mladezhki halm, Plovdiv",
          coordinates: { lat: 42.148828, lng: 24.741773 },
        },
      ];

      addresses.forEach((address) => {
        const marker = new window.google.maps.Marker({
          position: address.coordinates,
          map: map,
          title: address.name,
        });

        const infoWindow = new window.google.maps.InfoWindow({
          content: `<p>${address.name}</p>`,
        });

        marker.addListener("click", () => {
          infoWindow.open(map, marker);
        });
      });
    };

    return () => {
      document.head.removeChild(script);
    };
  }, []);

  return (
    <div
      id="map"
      style={{
        width: "70%",
        height: "40rem",
        border: "1px solid black",
        marginBottom: "1rem",
      }}
    ></div>
  );
}

export default GoogleMap;
