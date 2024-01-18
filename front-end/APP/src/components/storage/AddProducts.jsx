import styles from "./AddProducts.module.css";

import LoaderWheel from "../LoaderWheel.jsx";
import { useContext, useEffect, useState } from "react";
import { UserContext } from "../../context/GlobalUserProvider.jsx";
import { get } from "../../util/api.js";
import { environment } from "../../environments/environment.js";

function AddProducts() {
  const { user } = useContext(UserContext);
  const [loading, setLoading] = useState(false);
  const [suppliers, setSuppliers] = useState([]);
  const [selId, setSelId] = useState("");
  const [selSup, setSelSup] = useState({});
  const [selected, setSelected] = useState({});

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
        setSelected(result);
      }
      getSelected();
    },
    [selId, suppliers]
  );

  function onSelectSupplier(e) {
    setSelId(e.target.value);
  }
  return (
    <>
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
          <p className={`${styles.supInfo} ${styles.name}`}>{selSup.name}</p>
          <p className={`${styles.supInfo} ${styles.contName}`}>
            {selSup.contactName}
          </p>
          <p className={`${styles.supInfo} ${styles.email}`}>{selSup.email}</p>
          <p className={`${styles.supInfo} ${styles.phone}`}>
            {/* <span>
              <ion-icon name="call-outline"></ion-icon>
            </span> */}
            {selSup.phoneNumeber}
          </p>
        </div>
      </section>
    </>
  );
}
export default AddProducts;
