import { useContext, useEffect, useState } from "react";

import styles from "./WorkerOrders.module.css";

import { get } from "../../../util/api.js";
import OrderItem from "../OrderItem.jsx";
import BoardHeader from "../BoardHeader.jsx";
import { UserContext } from "../../../context/GlobalUserProvider.jsx";
import { environment } from "../../../environments/environment.js";

const MOCK_DATA = [
  {
    id: 4,
    ownerId: 1,
    serialNumber: "BID28YUOCH0",
    dateCreated: "15/09/2023",
    orderStates: [
      {
        partId: 1,
        partType: "Frame 4",
        partModel: "First Frame OG 4",
        nameOfEmplоyeeProducedThePart: "Jaba The Hut",
        isProduced: true,
        startedTime: 1701974864834,
        finishedTime: 1701974877891,
        description: "",
      },
      {
        partId: 2,
        partType: "Wheel from ID 4",
        partModel: "Wheel of the Year",
        nameOfEmplоyeeProducedThePart: "",
        isProduced: false,
        startedTime: "",
        finishedTime: "",
        description: "",
      },
      {
        partId: 3,
        partType: "Shift from ID 4",
        partModel: "Shift from ID 4",
        nameOfEmplоyeeProducedThePart: "",
        isProduced: false,
        startedTime: "",
        finishedTime: "",
        description: "",
      },
    ],
  },
  {
    id: 1,
    ownerId: 2,
    serialNumber: "BID28YUOCH0",
    dateCreated: "15/11/2023",
    orderStates: [
      {
        partId: 1,
        partType: " Second Frame 1",
        partModel: "Frame OG 1",
        nameOfEmplоyeeProducedThePart: "Jaba The Hut",
        isProduced: true,
        startedTime: 1701634811501,
        finishedTime: 1701635050418,
        description: "",
      },
      {
        partId: 2,
        partType: "Wheel from ID 1",
        partModel: "Wheel of the Year",
        nameOfEmplоyeeProducedThePart: "Luke Skywalker",
        isProduced: true,
        startedTime: 1701635767403,
        finishedTime: 1701635806376,
        description: "",
      },
      {
        partId: 3,
        partType: "Shift  from ID 1",
        partModel: "Shift  from ID 1",
        nameOfEmplоyeeProducedThePart: "Lea Organa",
        isProduced: false,
        startedTime: 1701635970424,
        finishedTime: "",
        description: "",
      },
    ],
  },
  {
    id: 2,
    ownerId: 3,
    serialNumber: "BID28YUOCH0",
    dateCreated: "06/01/2023",
    orderStates: [
      {
        partId: 1,
        partType: "Some Frame 2",
        partModel: "Frame OG 2",
        nameOfEmplоyeeProducedThePart: "Jaba The Hut",
        isProduced: true,
        startedTime: 1702195213128,
        finishedTime: 1702195266837,
        description: "",
      },
      {
        partId: 2,
        partType: "Wheel 2",
        partModel: "Wheel of the Year 2",
        nameOfEmplоyeeProducedThePart: "",
        isProduced: false,
        startedTime: "",
        finishedTime: "",
        description: "",
      },
      {
        partId: 3,
        partType: "Shift 2",
        partModel: "Shift 2",
        nameOfEmplоyeeProducedThePart: " ",
        isProduced: false,
        startedTime: "",
        finishedTime: "",
        description: "",
      },
    ],
  },
  {
    id: 6,
    ownerId: 1,
    serialNumber: "BID28YUOCH0",
    dateCreated: "06/01/2023",
    orderStates: [
      {
        partId: 1,
        partType: "Some Frame 2",
        partModel: "Frame OG 2",
        nameOfEmplоyeeProducedThePart: "Jaba The Hut",
        isProduced: true,
        startedTime: 1701635897633,
        finishedTime: 1701642057452,
        description: "",
      },
      {
        partId: 2,
        partType: "Wheel 2",
        partModel: "Wheel of the Year",
        nameOfEmplоyeeProducedThePart: "Luke Skywalker",
        isProduced: true,
        startedTime: 1701642100907,
        finishedTime: 1701642100917,
        description: "",
      },
      {
        partId: 3,
        partType: "Shift 2",
        partModel: "Shift 2",
        nameOfEmplоyeeProducedThePart: "Lea Organa",
        isProduced: true,
        startedTime: 1901635899633,
        finishedTime: 1901635899633,
        description: "",
      },
    ],
  },
  {
    id: 14,
    ownerId: 3,
    serialNumber: "BID28YUOCH0",
    dateCreated: "18/10/2023",
    orderStates: [
      {
        partId: 1,
        partType: "Some Frame",
        partModel: "Frame OG",
        nameOfEmplоyeeProducedThePart: "",
        isProduced: false,
        startedTime: "",
        finishedTime: "",
        description: "",
      },
      {
        partId: 2,
        partType: "Wheel 2",
        partModel: "Wheel of the Year 2",
        nameOfEmplоyeeProducedThePart: "",
        isProduced: false,
        startedTime: "",
        finishedTime: "",
        description: "",
      },
      {
        partId: 3,
        partType: "Shift 2",
        partModel: "Shift 2",
        nameOfEmplоyeeProducedThePart: " ",
        isProduced: false,
        startedTime: "",
        finishedTime: "",
        description: "",
      },
    ],
  },
];

function WorkerOrders() {
  // TODO: докато оправят сървъра
  // const { user } = useContext(UserContext);
  const [workerList, setWorkerList] = useState([]);
  const [isFinished, setIsFinished] = useState(false);
  const [meta, setMeta] = useState({});

  useEffect(
    function () {
      let orderArray;
      const abortController = new AbortController();

      async function getJobs() {
        // TODO: докато оправят сървъра
        // const workerSequence = await get(environment.worker_order_queue);
        const workerSequence = MOCK_DATA;
        const user = { department: "Frames" };

        workerSequence.sort((a, b) => a.dateCreated - b.dateCreated);

        setMeta({ id: workerSequence.id });

        // Worker will see only his own work
        if (user.department === "Frames") {
          orderArray = workerSequence.filter(
            (x) => !x.orderStates[0].isProduced
          );
        } else if (user.department === "Wheels") {
          orderArray = workerSequence.filter(
            (x) => x.orderStates[0].isProduced && !x.orderStates[1].isProduced
          );
        } else if (user.department === "Accessory") {
          orderArray = workerSequence.filter(
            (x) =>
              x.orderStates[0].isProduced &&
              x.orderStates[1].isProduced &&
              !x.orderStates[2].isProduced
          );
        }
        console.log(workerSequence);
        setWorkerList(orderArray);
      }
      getJobs();

      return () => abortController.abort();
    },
    [isFinished]
  );
  function onBtnHandler() {
    setIsFinished(!isFinished);
    console.log("rerender");
  }
  return (
    <>
      <h2 className={styles.dashHeading}>Orders in sequence</h2>
      <section className={styles.board}>
        <BoardHeader />
        <div className={styles.orders}>
          {workerList.length > 0 &&
            workerList.map((order, i) => (
              <OrderItem
                product={order}
                key={order.id}
                onBtnHandler={onBtnHandler}
                orderId={order.id}
                orderIndex={i}
              />
            ))}
          {workerList.length === 0 && (
            <h2>There is no orders in this category</h2>
          )}
        </div>
      </section>
    </>
  );
}

export default WorkerOrders;
