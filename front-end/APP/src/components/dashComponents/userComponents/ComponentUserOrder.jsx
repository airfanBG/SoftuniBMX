import { useState } from "react";

import { environment } from "../../../environments/environment.js";
import BoardHeader from "../BoardHeader.jsx";
import LoaderWheel from "../../LoaderWheel.jsx";
import React, { useEffect } from "react";
import { get } from "../../../util/api.js";
import { useParams } from "react-router-dom";

function ComponentUserOrder() {
  const { orderId } = useParams();
  const [loading, setLoading] = useState(false);
  const [data, setData] = useState({});

  useEffect(() => {
    async function getData() {
      try {
        const result = await get(environment.find_order + orderId);
        setData(result);
      } catch (error) {
        console.error("Error fetching data:", error);
      }
    }

    getData();
  }, [orderId]);

  return (
    <>
      <section>
        <BoardHeader />
        {loading && <LoaderWheel />}
      </section>
    </>
  );
}

export default ComponentUserOrder;
