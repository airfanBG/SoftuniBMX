import styles from "./StorageMain.module.css";

import BoardHeader from "../dashComponents/BoardHeader.jsx";
import Popup from "../Popup.jsx";
import { useState } from "react";
import AddProducts from "./AddProducts.jsx";
import Scrap from "./Scrap.jsx";
import Warehouse from "./Warehouse.jsx";
import AddSupplier from "./AddSupplier.jsx";

function StorageMain() {
  const [background, setBackground] = useState(false);
  const [active, setActive] = useState("warehouse");

  function close(e) {
    // setCurrentOrder({});
    // setBackground(false);
  }

  function onSelectActive(selected) {
    if (active === selected) return;
    setActive(selected);
  }

  return (
    <>
      {background && <Popup close={close}></Popup>}
      <h2 className={styles.dashHeadingMain}>Storage</h2>

      <section className={styles.board}>
        <BoardHeader />

        <div className={styles.wrapper}>
          <aside className={styles.control}>
            <button
              className={styles.actionLink}
              onClick={() => onSelectActive("warehouse")}
            >
              Warehouse
            </button>

            <button
              className={styles.actionLink}
              onClick={() => onSelectActive("scrap")}
            >
              Scrap
            </button>

            <button
              className={styles.actionLink}
              onClick={() => onSelectActive("add")}
            >
              Request parts
            </button>

            <button
              className={styles.actionLink}
              onClick={() => onSelectActive("supplier")}
            >
              Add suppliers
            </button>
          </aside>
          <main className={styles.main}>
            {active === "warehouse" && <Warehouse />}
            {active === "scrap" && <Scrap />}
            {active === "add" && <AddProducts />}
            {active === "supplier" && (
              <AddSupplier onFinish={onSelectActive} active="warehouse" />
            )}
          </main>
        </div>
      </section>
    </>
  );
}

export default StorageMain;
