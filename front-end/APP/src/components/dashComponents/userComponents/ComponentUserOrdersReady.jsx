import styles from "./ComponentUserOrdersReady.module.css";
import UserOrdersTable from "./UserOrdersTable.jsx";

import { useContext, useState } from "react";

import { UserContext } from "../../../context/GlobalUserProvider.jsx";

import BoardHeader from "../BoardHeader.jsx";
import LoaderWheel from "../../LoaderWheel.jsx";

function ComponentUserOrdersReady() {
  const { user } = useContext(UserContext);
  const [loading, setLoading] = useState(false);

  const object = [
    {
      orderId: 10,
      serialNumber: "BIDPASQC123",
      orderDate: "16.12.2023",
      amount: 425,
      parts: [
        {
          id: 1,
          name: "Frame OG",
        },
        {
          id: 2,
          name: "Wheel of the YearG",
        },
        {
          id: 3,
          name: "Shift",
        },
      ],
    },
    {
      orderId: 9,
      serialNumber: "BID12345680",
      orderDate: "16.12.2023",
      amount: 850,
      parts: [
        {
          id: 1,
          name: "Frame OG",
        },
        {
          id: 5,
          name: "Wheel of the Year for montain",
        },
        {
          id: 11,
          name: "Road budget Shifts",
        },
      ],
    },
    {
      orderId: 8,
      serialNumber: "BID12345680",
      orderDate: "16.12.2023",
      amount: 850,
      parts: [
        {
          id: 1,
          name: "Frame OG",
        },
        {
          id: 5,
          name: "Wheel of the Year for montain",
        },
        {
          id: 11,
          name: "Road budget Shifts",
        },
      ],
    },
    {
      orderId: 7,
      serialNumber: "BID12345680",
      orderDate: "16.12.2023",
      amount: 650,
      parts: [
        {
          id: 1,
          name: "Frame OG",
        },
        {
          id: 5,
          name: "Wheel of the Year for montain",
        },
        {
          id: 11,
          name: "Road budget Shifts",
        },
      ],
    },
    {
      orderId: 6,
      serialNumber: "BID12345680",
      orderDate: "16.12.2023",
      amount: 850,
      parts: [
        {
          id: 1,
          name: "Frame OG",
        },
        {
          id: 5,
          name: "Wheel of the Year for montain",
        },
        {
          id: 11,
          name: "Road budget Shifts",
        },
      ],
    },
    {
      orderId: 5,
      serialNumber: "BID12345680",
      orderDate: "16.12.2023",
      amount: 850,
      parts: [
        {
          id: 1,
          name: "Frame OG",
        },
        {
          id: 5,
          name: "Wheel of the Year for montain",
        },
        {
          id: 11,
          name: "Road budget Shifts",
        },
      ],
    },
    {
      orderId: 4,
      serialNumber: "BID12345680",
      orderDate: "16.12.2023",
      amount: 650,
      parts: [
        {
          id: 1,
          name: "Frame OG",
        },
        {
          id: 5,
          name: "Wheel of the Year for montain",
        },
        {
          id: 11,
          name: "Road budget Shifts",
        },
      ],
    },
    {
      orderId: 3,
      serialNumber: "BID12345680",
      orderDate: "16.12.2023",
      amount: 950,
      parts: [
        {
          id: 1,
          name: "Frame OG",
        },
        {
          id: 5,
          name: "Wheel of the Year for montain",
        },
        {
          id: 11,
          name: "Road budget Shifts",
        },
      ],
    },
    {
      orderId: 2,
      serialNumber: "BID12345679",
      orderDate: "16.12.2023",
      amount: 850,
      parts: [
        {
          id: 1,
          name: "Frame OG",
        },
        {
          id: 4,
          name: "Wheel of the Year for road",
        },
        {
          id: 12,
          name: "Shift",
        },
      ],
    },
    {
      orderId: 1,
      serialNumber: "BID12345678",
      orderDate: "16.12.2023",
      amount: 750,
      parts: [
        {
          id: 1,
          name: "Frame OG",
        },
        {
          id: 2,
          name: "Wheel of the YearG",
        },
        {
          id: 3,
          name: "Shift",
        },
      ],
    },
  ];

  return (
    <>
      <h2 className={styles.dashHeading}>Selected items</h2>

      <section className={styles.board}>
        <BoardHeader />
        {loading && <LoaderWheel />}
        <UserOrdersTable orders={object}/>
      </section>
    </>
  );
}

export default ComponentUserOrdersReady;
