import styles from "./Home.module.css";

import Header from "./Header.jsx";
import ModelSelection from "./ModelSelection.jsx";
import Testimonials from "./Testimonials.jsx";
import Footer from "../../components/Footer.jsx";
import UserContent from "./UserContent.jsx";
import { createContext, useEffect, useState } from "react";
import { get } from "../../util/api.js";
import { environment } from "../../environments/environment.js";

export const HomeContext = createContext();

function Home() {
  const [loading, setLoading] = useState(false);
  const [bikes, setBikes] = useState([]);
  const [comments, setComments] = useState([]);
  const [top, setTop] = useState(0);

  useEffect(
    function () {
      async function homePageData() {
        setLoading(true);
        try {
          const data = await get(environment.indexPage);
          // const brakeHeapRelation = [...data.defaultBikes];
          // const currentTop = brakeHeapRelation
          const currentTop = [...data.defaultBikes]
            .sort((a, b) => b.price - a.price)
            .at(0).price;
          setTop(currentTop);

          if (!data)
            throw new Error("Something went wrong! Please try again later");

          setLoading(false);
          setBikes(data.defaultBikes);
          setComments(data.comments);
        } catch (err) {
          console.error(err);
          setLoading(false);
          return err;
        }
      }
      homePageData();
    },
    [top]
  );

  return (
    <HomeContext.Provider
      value={{
        top: top,
        bikes: bikes,
        comments: comments,
      }}
    >
      <>
        <div className={styles["page-background"]}>
          <img src="./img/bg.webp" alt="Extreme sports pool" />
        </div>
        <Header />
        <main>
          <ModelSelection />
          <Testimonials />
          <UserContent />
        </main>
        <Footer />
      </>
    </HomeContext.Provider>
  );
}

export default Home;
