import styles from "./About.module.css";

import Navigation from "../../components/navigationsComponents/Navigation.jsx";
import Footer from "../../components/Footer.jsx";
import StarsRating from "../../components/Stars.jsx";
import { useState } from "react";
// import Form from "../../components/Form.jsx";

function About() {
  const [movieRating, setMovieRating] = useState(0);
  return (
    <div className={styles.compBody}>
      <Navigation />
      <div className={styles.container}>
        <div className={styles.content}>
          <h2 className={styles.heading}>
            About Bicycle Management eXtreme - BMX
          </h2>
          {/* <p className={styles.textPh}>
            Lorem ipsum dolor sit amet consectetur adipisicing elit. Atque nobis
            porro quos cupiditate iure laboriosam facilis vel corporis provident
            facere alias, accusamus modi nihil eligendi libero repudiandae earum
            ea debitis, et voluptates sed, rem est? Culpa beatae vel impedit,
            minus voluptates doloremque quos vitae ex, deserunt vero animi
            suscipit possimus!
          </p>

          <p className={styles.textPh}>
            Lorem ipsum dolor sit amet, consectetur adipisicing elit.
            Reprehenderit deserunt repudiandae, minima in quam ratione hic ullam
            eligendi consequuntur velit, voluptatem facere esse sit saepe
            placeat numquam praesentium eius sequi tempore. Excepturi alias,
            fugit pariatur blanditiis earum error. Sit, impedit. Eius, in
            reprehenderit praesentium rerum asperiores molestias eos, sed
            assumenda consequatur amet cumque hic rem ab illum, molestiae
            voluptates id voluptatibus incidunt autem doloremque iste esse. Modi
            perferendis minima numquam, eaque molestias labore? Perferendis,
            optio!
          </p> */}
          <p className={styles.textPh}>
            Приложението обслужва пълната функционалност на предприятие за
            производство на велосипеди, както и неговото менажиране. Заводът
            произвежда три основни модела велосипеди, като в зависимост от
            избора на клиента всеки компонент може да има по няколко
            разновидности.
          </p>
          <p className={styles.textPh}>
            Приложението дава възможност потребителя сам да сглоби велосипед,
            като избере, поетапно от възможностите - рамка, колела и аксесоари.
            При избиране на страницата CREATE се прави първоначална заявка за
            зареждане на възможностите за избор на рамка, като основна част на
            велосипеда. Приложението покрива всички дейности за потребителския
            избор и работения процес.
          </p>
          <p className={styles.textPh}>
            👤 От страна на клиента
            <ul style={{ listStyleType: "circle", paddingLeft: 60 }}>
              <li>
                избор на някой от базовите велосипеди или асемблиране на
                собствен модел от възможните предоставени като избор части.{" "}
              </li>
              <li>Проследяване на поръчката до нейното завършване</li>
              <li>Редактиране на клиентския профил</li>
              <li>Добавяне на средства за изплащане на избрания продукт</li>
            </ul>
          </p>
          <p className={styles.textPh}>
            🏭 От страна на предприятието
            <ul style={{ listStyleType: "circle", paddingLeft: 60 }}>
              <li>
                Изработване на избраната селекция и одобрение от качествен
                контрол
              </li>
              <li>Проследяване на работния процес </li>
              <li>
                Изработване и асемблиране на частите на текущите поръчки в
                съответните отдели
              </li>
              <li>
                Одобрение на продукта, връщане за рекламация на детаил или
                бракуване
              </li>
              <li>Добавяне на нови кадри, обслужващи работния процес </li>
              <li>
                Проследяване на работния процес на служителите, като екип и по
                отделно{" "}
              </li>
              <li>Начисляване на трудово възнаграждение </li>
              <li>Управление на склад и складова наличност</li>
              <li>Добавяне на нови доставчици </li>
              <li>
                Извършване на нови поръчки при недостатъчна наличност на части
              </li>
            </ul>
          </p>

          <div className={styles.img}>
            <img src="./img/about.webp" alt="" />
          </div>
        </div>
      </div>
      <Footer />
    </div>
  );
}

export default About;
