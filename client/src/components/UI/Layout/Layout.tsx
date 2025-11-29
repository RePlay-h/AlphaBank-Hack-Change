import { Outlet } from 'react-router-dom';
import styles from './layout.module.css';
import { Header } from '../index.ts';

const Layout = () => {
    return (
        <div>
            <Header />
            <main className={styles.layout}>
                <Outlet />
            </main>
        </div>
    );
};

export default Layout;
