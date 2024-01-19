import styles from "./AddProducts.module.css";

import LoaderWheel from "../LoaderWheel.jsx";
import { useContext, useEffect, useState } from "react";
import { UserContext } from "../../context/GlobalUserProvider.jsx";
import { get } from "../../util/api.js";
import { environment } from "../../environments/environment.js";
import { formatCurrency } from "../../util/resolvers.js";
import Popup from "../Popup.jsx";

function AddProducts() {
  const { user } = useContext(UserContext);
  const [loading, setLoading] = useState(false);
  const [suppliers, setSuppliers] = useState([]);
  const [selId, setSelId] = useState("");
  const [selSup, setSelSup] = useState({});
  const [selected, setSelected] = useState({});
  const [background, setBackground] = useState(false);
  const [currentImg, setCurrentImg] = useState("");

  useEffect(() => {
    async function getSuppliers() {
      const result = await get(environment.suppliers_list);
      if (!result.isError) {
        setSuppliers(result);
      }
    }
    getSuppliers();
  }, []);

  useEffect(
    function () {
      if (selId === "") return;
      suppliers.map((s) => {
        if (s.id == selId) {
          setSelSup(s);
        }
      });

      async function getSelected() {
        const result = await get(environment.get_supplier_parts + selId);
        if (result?.isError) {
          console.log(result.isError.message);
        }
        const sorted = result.sort((a, b) => a.quantity - b.quantity);
        setSelected(sorted);
      }
      getSelected();
    },
    [selId, suppliers]
  );

  function onSelectSupplier(e) {
    setSelId(e.target.value);
  }

  function onOrderButtonClick(i) {
    setCurrentImg(i);
    setBackground(true);
  }

  function close() {
    setCurrentImg({});
    setBackground(false);
  }

  return (
    <>
      {background && (
        <Popup onClose={close}>
          <>
            <img src={currentImg.img} alt="" />
            <p className={styles.description}>{currentImg.description}</p>
          </>
        </Popup>
      )}
      <h2 className={styles.dashHeading}>Create parts request</h2>

      <section className={styles.board}>
        {loading && <LoaderWheel />}

        <div className={styles.dropDown}>
          <select
            name=""
            id=""
            className={styles.selectEl}
            onChange={onSelectSupplier}
          >
            <option value=""></option>
            {suppliers &&
              suppliers.length > 0 &&
              suppliers.map((s) => (
                <option key={s.id} className={styles.option} value={s.id}>
                  {s.categoryName}
                </option>
              ))}
          </select>

          {Object.keys(selected).length === 0 && (
            <h3 className={styles.noHeading}>
              Select supplier from the dropdown list
            </h3>
          )}
          {Object.keys(selected).length > 0 && (
            <div className={styles.selectedInfo}>
              <p className={`${styles.supInfo} ${styles.name}`}>
                {selSup.name}
              </p>
              <p className={`${styles.supInfo} ${styles.contName}`}>
                {selSup.contactName}
              </p>

              <button
                className={`${styles.supInfo} ${styles.email}`}
                onClick={() => (window.location = `mailto:${selSup.email}`)}
              >
                {selSup.email}
              </button>
              <button
                className={`${styles.supInfo} ${styles.phone}`}
                onClick={
                  () => (window.location = `callto:${selSup.phoneNumeber}`)
                  // window.open(`tel:${selSup.phoneNumeber}`)
                }
              >
                <span>
                  <ion-icon name="call-outline"></ion-icon>
                </span>
                {selSup.phoneNumeber}
              </button>
            </div>
          )}
        </div>

        {Object.values(selected).length > 0 && (
          <ul className={styles.partsList}>
            {selected.map((s) => (
              <li className={styles.selectedListItem} key={s.id}>
                <p className={styles.element}>
                  <span className={styles.label}>Part</span>
                  {s.name}
                </p>
                <span
                  className={styles.icon}
                  onClick={() =>
                    onOrderButtonClick({
                      img: s.imageUrls.at(0),
                      description: s.description,
                    })
                  }
                >
                  <ion-icon name="search-outline"></ion-icon>
                </span>
                <p className={`${styles.element} ${styles.oem}`}>
                  <span className={styles.label}>OEM Number</span>
                  {s.oemNumber}
                </p>
                <p className={`${styles.element} ${styles.price}`}>
                  <span className={styles.label}>Price</span>
                  {formatCurrency(s.salePrice)}
                </p>
                <p
                  className={`${styles.element} ${styles.qty}`}
                  style={s.quantity < 20 ? { color: "red" } : null}
                >
                  <span className={styles.label}>Available:</span>
                  {s.quantity}
                </p>
                <p className={`${styles.element} ${styles.type}`}>
                  <span className={styles.label}>Type</span>
                  {s.type}
                </p>
                <p className={`${styles.element} ${styles.rating}`}>
                  <span className={styles.label}>Rating</span>
                  {Array.from({ length: s.rating }, (v) => "⭐")}
                </p>
                <p className={`${styles.element} ${styles.rating}`}>
                  <span className={styles.label}>Intend:</span>
                  {s.category}
                </p>

                <p className={`${styles.element} ${styles.rating}`}>
                  <span className={styles.label}>Quantity:</span>
                  <input type="number" className={`${styles.inputElement} `} />
                </p>

                <button className={styles.purchaseBtn}>Purchase</button>
              </li>
            ))}
          </ul>
        )}
      </section>
    </>
  );
}
export default AddProducts;
