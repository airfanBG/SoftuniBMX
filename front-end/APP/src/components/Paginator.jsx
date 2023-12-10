function Paginator({
  page = 1,
  pages,
  size = 25,
  bgColor = "#ededed",
  selected = "#bbbeee",
  brColor = "#888",
  brRadius = 2,
  fontSize = 1.6,
  handlePage,
  countOnPage,
}) {
  const paginatorLine = {
    display: "flex",
    alignItems: "center",
    justifyContent: "center",
    gap: "0.5rem",
  };
  return (
    <div style={paginatorLine}>
      {Array.from({ length: Math.ceil(pages / countOnPage) }, (_, i) => (
        <Page
          currentPage={page === i + 1}
          number={i + 1}
          key={i}
          size={size}
          bgColor={bgColor}
          bgColorHover={selected}
          brColor={brColor}
          brRadius={brRadius}
          handlePage={handlePage}
          fontSize={fontSize}
        >
          {i + 1}
        </Page>
      ))}
    </div>
  );
}

export default Paginator;

function Page({
  children,
  currentPage,
  size,
  bgColor,
  brColor,
  bgColorHover,
  brRadius,
  number,
  handlePage,
  fontSize,
}) {
  const pageStyle = {
    display: "flex",
    alignItems: "center",
    justifyContent: "center",
    backgroundColor: `${bgColor}`,
    width: `${size}px`,
    height: `${size}px`,
    cursor: "pointer",
    border: `1px solid ${brColor}`,
    borderRadius: `${brRadius}px`,
    fontSize: `${fontSize}rem`,
  };
  const pageSelected = {
    display: "flex",
    alignItems: "center",
    justifyContent: "center",
    backgroundColor: `${bgColorHover}`,
    width: `${size}px`,
    height: `${size}px`,
    cursor: "pointer",
    border: `1px solid ${brColor}`,
    borderRadius: `${brRadius}px`,
    fontSize: `${fontSize}rem`,
  };
  return (
    <div
      style={currentPage ? pageSelected : pageStyle}
      onClick={() => handlePage(number)}
    >
      {children}
    </div>
  );
}
